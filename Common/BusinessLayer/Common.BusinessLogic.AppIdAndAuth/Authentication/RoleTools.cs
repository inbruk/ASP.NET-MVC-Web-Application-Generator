namespace Common.BusinessLogic.AppIdAndAuth.Authentication
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CryptoTools;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.AppIdAndAuth.Authentication;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class RoleTools
    {
        private static LazyInitWithoutParams<DAL.Common_AppIdAndAuth_Entities> CurrDBContext;

        public static long Create( String enumName, Boolean isReadOnly, Boolean isDeleted )
        {
            DAL.tblAuthenticationRole currItem = new DAL.tblAuthenticationRole()
            {
                EnumName = enumName,
                IsReadOnly = isReadOnly,
                IsDeleted = isDeleted                
            };
            CurrDBContext.Get().tblAuthenticationRole.Add(currItem);
            CurrDBContext.Get().SaveChanges();

            long id = currItem.Id;
            return id;
        }

        public static Role Read(long id)
        {
            Role result =
                CurrDBContext.Get().tblAuthenticationRole.Where(x => x.Id == id).Select
                (
                    x =>
                    new Role()
                    {
                        Id = x.Id,
                        EnumName = x.EnumName,
                        IsReadOnly = x.IsReadOnly,
                        IsDeleted = x.IsDeleted
                    }
                ).Single();

            return result;
        }

        public static List<Role> Read(List<long> idList)
        {
            if (idList.Count > CommonConstants.MaxListSize)
            {
                throw new Exception("Maximum list size is exceeded in RoleTools.Read(list) !");
            }

            List<Role> result =
                CurrDBContext.Get().tblAuthenticationRole.Where(x => idList.Contains(x.Id)).Select
                (
                    x =>
                    new Role()
                    {
                        Id = x.Id,
                        EnumName = x.EnumName,
                        IsReadOnly = x.IsReadOnly,
                        IsDeleted = x.IsDeleted
                    }
                ).ToList();

            return result;
        }

        // for password Changing set 'Password' field to value, otherwise set 'Password' field = null
        // if PasswordSalt and PasswordHash recalculated to new values. It must changed in newActor too
        public static void Update(Role newRole)
        {
            DAL.tblAuthenticationRole dataItem = CurrDBContext.Get().tblAuthenticationRole.Where(x => x.Id == newRole.Id).Single();

            dataItem.EnumName = newRole.EnumName;
            dataItem.IsReadOnly = newRole.IsReadOnly;
            dataItem.IsDeleted = newRole.IsDeleted;

            CurrDBContext.Get().SaveChanges();
        }

        public static void Delete(long id)
        {
            Role curr = Read(id);
            curr.IsDeleted = true;
            Update(curr);
        }

        public static void UnDelete(long id)
        {
            Role curr = Read(id);
            curr.IsDeleted = false;
            Update(curr);
        }

    }
}
