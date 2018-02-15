namespace Common.BusinessLogic.AppIdAndAuth.Authentication
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.CryptoTools;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.AppIdAndAuth.Authentication;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class ActorTools 
    {
        private static LazyInitWithoutParams<DAL.Common_AppIdAndAuth_Entities> CurrDBContext;

        public static long Create(String login, String password, long roleId)
        {
            SHA1Hasher.CalculatePasswordHash(password, out String passwordSalt, out String passwordHash);

            DAL.tblAuthenticationActor currItem = new DAL.tblAuthenticationActor()
            {
                Login = login,
                PasswordSalt = passwordHash,
                PasswordHash = passwordHash,
                IsBanned = false,
                RoleId = roleId
            };
            CurrDBContext.Get().tblAuthenticationActor.Add(currItem);
            CurrDBContext.Get().SaveChanges();

            long id = currItem.Id;
            return id;
        }

        public static Actor Read(long id)
        {
            Actor result = 
                CurrDBContext.Get().tblAuthenticationActor.Where( x => x.Id==id ).Select
                (
                    x => 
                    new Actor()
                    {
                        Id = x.Id,
                        Login = x.Login,
                        PasswordSalt = x.PasswordSalt,
                        PasswordHash = x.PasswordHash,
                        IsBanned = false,
                        RoleId = x.RoleId                        
                    }
                ).SingleOrDefault();

            return result;
        }

        public static Actor Read(String login)
        {
            Actor result =
                CurrDBContext.Get().tblAuthenticationActor.Where(x => x.Login==login ).Select
                (
                    x =>
                    new Actor()
                    {
                        Id = x.Id,
                        Login = x.Login,
                        PasswordSalt = x.PasswordSalt,
                        PasswordHash = x.PasswordHash,
                        IsBanned = false,
                        RoleId = x.RoleId
                    }
                ).SingleOrDefault();

            return result;
        }

        public static List<Actor> Read(List<long> idList)
        {
            if( idList.Count > Constants.MaxListSize )
            {
                throw new Exception("Maximum list size is exceeded in ActorTools.Read(list) !");
            }

            List<Actor> result =
                CurrDBContext.Get().tblAuthenticationActor.Where( x => idList.Contains(x.Id) ).Select
                (
                    x =>
                    new Actor()
                    {
                        Id = x.Id,
                        Login = x.Login,
                        PasswordSalt = x.PasswordSalt,
                        PasswordHash = x.PasswordHash,
                        IsBanned = false,
                        RoleId = x.RoleId
                    }
                ).ToList();

            return result;
        }


        // for password Changing set 'Password' field to value, otherwise set 'Password' field = null
        // if PasswordSalt and PasswordHash recalculated to new values. It must changed in newActor too
        public static void Update(Actor newActor) 
        {
            DAL.tblAuthenticationActor dataItem = CurrDBContext.Get().tblAuthenticationActor.Where(x => x.Id == newActor.Id).Single();

            dataItem.Login = newActor.Login;
            dataItem.IsBanned = newActor.IsBanned;
            dataItem.RoleId = newActor.RoleId;

            if (newActor.Password != null)
            {
                SHA1Hasher.CalculatePasswordHash(newActor.Password, out String passwordSalt, out String passwordHash);
                dataItem.PasswordSalt = passwordSalt;
                dataItem.PasswordHash = passwordHash;

                newActor.PasswordSalt = passwordSalt;
                newActor.PasswordHash = passwordHash;
            }

            CurrDBContext.Get().SaveChanges();
        }

        public static void Ban(long id)
        {
            Actor curr = Read(id);
            curr.IsBanned = true;
            Update(curr);
        }

        public static void UnBan(long id)
        {
            Actor curr = Read(id);
            curr.IsBanned = false;
            Update(curr);
        }
    }
}
