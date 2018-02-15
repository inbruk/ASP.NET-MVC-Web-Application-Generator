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
        public static TokenItem LogIn(String login, String password)
        {
            // check for id in use !!!!!!!!!!!
            Actor currActor = ActorTools.Read(login);
            if (currActor != null)
                return null; // actor with such login exists already



            





            // create TokenItem 
            Guid actToken = Guid.NewGuid();
            Guid refToken = Guid.NewGuid();
            TokenItem result = new TokenItem(currActor.Id, actToken, refToken);

            // save TokenItem in memory storage
            StoragePerApplication.Put(actToken.ToString(), result);
            
            return result;
        }

        public static void LogOut(TokenItem currItem)
        {
            Guid actToken = currItem.ActionToken;
            StoragePerApplication.Remove( actToken.ToString() );
        }

        private static TokenItem localRefreshTokens(TokenItem currItem) // only for internal use when actor is actually logged in
        {
            Guid actToken = Guid.NewGuid();
            Guid refToken = Guid.NewGuid();

            TokenItem result = new TokenItem(currItem.Id, actToken, refToken);

            return result;
        }

        public static TokenItem CheckIsLoggedInAndRefresh(TokenItem currItem)
        {
            if( currItem.IsRefreshTokenActual()==false )
            {
                LogOut(currItem);
                return null;
            }

            if (currItem.IsActionTokenActual() == false)
            {
                currItem = localRefreshTokens(currItem);
                return null;
            }

            return currItem;
        }
    }
}
