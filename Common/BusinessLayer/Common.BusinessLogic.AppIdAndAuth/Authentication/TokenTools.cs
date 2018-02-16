namespace Common.BusinessLogic.AppIdAndAuth.Authentication
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CryptoTools;
    using Auxiliary.StorageTools;

    using Common.DataTransferObjects.AppIdAndAuth.Authentication;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class TokenTools
    {
#region work with storage 

        private static String _createStorageKeyFromUserIdAndAppId(long id, long appId)
        {
            return id.ToString() + "_AppId" + appId.ToString();
        }

        private static void _saveTokenValueByUserIdAndAppId(long id, long appId, Guid? token)
        {
            String storageKey = _createStorageKeyFromUserIdAndAppId(id, appId);
            StoragePerApplication.Put(storageKey, token);
        }

        private static Guid? _loadTokenValueByUserIdAndAppId(long id, long appId)
        {
            String storageKey = _createStorageKeyFromUserIdAndAppId(id, appId);
            Guid? token = (Guid?) StoragePerApplication.Get(storageKey);
            return token;
        }

        private static void _removeTokenValueByUserIdAndAppId(long id, long appId)
        {
            String storageKey = _createStorageKeyFromUserIdAndAppId(id, appId);
            StoragePerApplication.Remove(storageKey);
        }

        private static void _saveTokenItemByToken(Guid? token, TokenItem ti)
        {
            String storageKey = token.ToString();
            StoragePerApplication.Put(storageKey, ti);
        }

        private static TokenItem _loadTokenItemByToken(Guid? token)
        {
            String storageKey = token.ToString();
            TokenItem tokenItem = (TokenItem) StoragePerApplication.Get(storageKey);
            return tokenItem;
        }

        private static void _removeTokenItemByToken(Guid? token)
        {
            String storageKey = token.ToString();
            StoragePerApplication.Remove(storageKey);
        }

#endregion work with storage

        public static TokenItem LogIn(String login, String password, long appId)
        {
            // load user and check for user unexistence
            Actor currActor = ActorTools.Read(login);
            if (currActor == null)
                return null; // can't login unexistent user

            // check for [id,appId] in use already
            long currActorId = currActor.Id;
            Guid? currToken = _loadTokenValueByUserIdAndAppId(currActorId, appId);
            if( currToken!= null) // [id,appId] already in use !!!
            {
                // we need to log out old working user before login new one
                // we log out when all values known now !!!
                _removeTokenValueByUserIdAndAppId(currActorId, appId);
                _removeTokenItemByToken(currToken);
            }

            // create TokenItem for new user
            Guid newActionToken = Guid.NewGuid();
            Guid refToken = Guid.NewGuid();
            TokenItem newTokenItem = new TokenItem(currActor.Id, appId, newActionToken, refToken);

            // save new TokenItem and new token in memory storage     
            _saveTokenValueByUserIdAndAppId(currActor.Id, appId, newActionToken);
            _saveTokenItemByToken(newActionToken, newTokenItem);
            
            return newTokenItem;
        }

        public static void LogOut(TokenItem currItem)
        {
            Guid actToken = currItem.ActionToken;
            _removeTokenValueByUserIdAndAppId(currItem.Id, currItem.ApplicationId);
            _removeTokenItemByToken(actToken);
        }

        private static TokenItem _refreshTokens(TokenItem currItem) // only for internal use when actor is actually logged in
        {
            // remove all current data from storage 
            LogOut(currItem);

            Guid actToken = Guid.NewGuid();
            Guid refToken = Guid.NewGuid();
            TokenItem result = new TokenItem(currItem.Id, currItem.ApplicationId, actToken, refToken);

            // save new TokenItem and new token in memory storage     
            _saveTokenValueByUserIdAndAppId( result.Id, result.ApplicationId, result.ActionToken );
            _saveTokenItemByToken( result.ActionToken, result );

            return result;
        }

        public static TokenItem CheckIsLoggedInAndRefreshIfNeed(TokenItem currItem)
        {
            if( currItem.IsRefreshTokenActual()==false )
            {
                LogOut(currItem);
                return null;
            }

            if (currItem.IsActionTokenActual() == false)
                currItem = _refreshTokens(currItem);

            return currItem;
        }
    }
}
