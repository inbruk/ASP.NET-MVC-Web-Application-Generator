namespace Common.BusinessLogic.Authentication0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Data.Sql;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Common.DataTransferObjects.AppIdAndAuth.Authentication;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;
    using Auxiliary.CryptoTools;

    public class ActorTools
    {
        private DAL.Common_AppIdAndAuth_Entities _internalDBContext = null;
        private DAL.Common_AppIdAndAuth_Entities CurrDBContext
        {
            get
            {
                if( _internalDBContext==null )
                {
                    _internalDBContext = new DAL.Common_AppIdAndAuth_Entities();
                }
                return _internalDBContext;
            }
        }

        private void CalculatePasswordHash(String password, out String passwordSalt, out String passwordHash)
        {
            passwordSalt = SHA1Hasher.GetUsefulSalt();
            passwordHash = SHA1Hasher.EncodePassword(password, passwordSalt);
        }

        public long Create(String login, String password)
        {           
            CalculatePasswordHash(password, out String passwordSalt, out String passwordHash);

            DAL.tblAuthenticationActor currItem = new DAL.tblAuthenticationActor()
            {
                Login = login,
                PasswordSalt = passwordHash,
                PasswordHash = passwordHash,
                IsBanned = false
            };
            CurrDBContext.tblAuthenticationActor.Add(currItem);
            CurrDBContext.SaveChanges();

            long id = currItem.Id;
            return id;
        }

        public Actor Read(long id)
        {
            Actor result = 
                CurrDBContext.tblAuthenticationActor.Where( x => x.Id==id ).Select
                (
                    x => 
                    new Actor()
                    {
                        Id = x.Id,
                        Login = x.Login,
                        PasswordSalt = x.PasswordSalt,
                        PasswordHash = x.PasswordHash,
                        IsBanned = false
                    }
                ).Single();

            return result;
        }

        // for password Changing set 'Password' field to value, otherwise set 'Password' field = null
        // if PasswordSalt and PasswordHash recalculated to new values. It must changed in newActor too
        public void Update(Actor newActor) 
        {
            DAL.tblAuthenticationActor dataItem = CurrDBContext.tblAuthenticationActor.Where(x => x.Id == newActor.Id).Single();

            dataItem.Login = newActor.Login;
            dataItem.IsBanned = newActor.IsBanned;

            if (newActor.Password != null)
            {
                CalculatePasswordHash(newActor.Password, out String passwordSalt, out String passwordHash);
                dataItem.PasswordSalt = passwordSalt;
                dataItem.PasswordHash = passwordHash;

                newActor.PasswordSalt = passwordSalt;
                newActor.PasswordHash = passwordHash;
            }       
        }

        public void Ban(long id)
        {
            Actor curr = Read(id);
            curr.IsBanned = true;
            Update(curr);
        }

        public void UnBan(long id)
        {
            Actor curr = Read(id);
            curr.IsBanned = false;
            Update(curr);
        }
    }
}
