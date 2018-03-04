namespace Common.BusinessLogicLayer.AppIdAndAuth.Authentication
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
        public static long Create(String login, String password, long roleId)
        {
            SHA1Hasher.CalculatePasswordHash(password, out String passwordSalt, out String passwordHash);

            DAL.tblAuthenticationActor currItem = new DAL.tblAuthenticationActor()
            {
                Login = login,
                PasswordSalt = passwordHash,
                PasswordHash = passwordHash,
                IsDeleted = false,
                RoleId = roleId
            };
            DAL.CurrDBContext.Get().tblAuthenticationActor.Add(currItem);
            DAL.CurrDBContext.Get().SaveChanges();

            long id = currItem.Id;
            return id;
        }

        public static Actor Read(long id, Boolean WithActive = true, Boolean WithDeleted = false)
        {
            Actor result = 
                  DAL.CurrDBContext.Get().tblAuthenticationActor.Where( x => x.Id==id && 
                    ( x.IsDeleted==(!WithActive) || x.IsDeleted == WithDeleted )
                ).Select (
                    x => 
                    new Actor()
                    {
                        Id = x.Id,
                        Login = x.Login,
                        PasswordSalt = x.PasswordSalt,
                        PasswordHash = x.PasswordHash,
                        IsDeleted = false,
                        RoleId = x.RoleId                        
                    }
                ).SingleOrDefault();

            return result;
        }

        public static Actor Read(String login, Boolean WithActive = true, Boolean WithDeleted = false)
        {
            Actor result =
                DAL.CurrDBContext.Get().tblAuthenticationActor.Where(x => x.Login==login &&
                    (x.IsDeleted == (!WithActive) || x.IsDeleted == WithDeleted)
                ).Select (
                    x =>
                    new Actor()
                    {
                        Id = x.Id,
                        Login = x.Login,
                        PasswordSalt = x.PasswordSalt,
                        PasswordHash = x.PasswordHash,
                        IsDeleted = false,
                        RoleId = x.RoleId
                    }
                ).SingleOrDefault();

            return result;
        }

        public static List<Actor> Read(List<long> idList, Boolean WithActive = true, Boolean WithDeleted = false)
        {
            if( idList.Count > Constants.MaxListSize )
            {
                throw new Exception("Maximum list size is exceeded in ActorTools.Read(list) !");
            }

            List<Actor> result =
                DAL.CurrDBContext.Get().tblAuthenticationActor.Where( x => idList.Contains(x.Id) &&
                    (x.IsDeleted == (!WithActive) || x.IsDeleted == WithDeleted)
                ).Select (
                    x =>
                    new Actor()
                    {
                        Id = x.Id,
                        Login = x.Login,
                        PasswordSalt = x.PasswordSalt,
                        PasswordHash = x.PasswordHash,
                        IsDeleted = false,
                        RoleId = x.RoleId
                    }
                ).ToList();

            return result;
        }


        // for password Changing set 'Password' field to value, otherwise set 'Password' field = null
        // if PasswordSalt and PasswordHash recalculated to new values. It must changed in newActor too
        public static void Update(Actor newActor) 
        {
            DAL.tblAuthenticationActor dataItem = DAL.CurrDBContext.Get().tblAuthenticationActor.Where(x => x.Id == newActor.Id).Single();

            dataItem.Login = newActor.Login;
            dataItem.IsDeleted = newActor.IsDeleted;
            dataItem.RoleId = newActor.RoleId;

            if (newActor.Password != null)
            {
                SHA1Hasher.CalculatePasswordHash(newActor.Password, out String passwordSalt, out String passwordHash);
                dataItem.PasswordSalt = passwordSalt;
                dataItem.PasswordHash = passwordHash;

                newActor.PasswordSalt = passwordSalt;
                newActor.PasswordHash = passwordHash;
            }

            DAL.CurrDBContext.Get().SaveChanges();
        }

        public static void Delete(long id)
        {
            Actor curr = Read(id);
            curr.IsDeleted = true;
            Update(curr);
        }

        public static void UnDelete(long id)
        {
            Actor curr = Read(id);
            curr.IsDeleted = false;
            Update(curr);
        }
    }
}
