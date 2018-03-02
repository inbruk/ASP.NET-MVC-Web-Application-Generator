namespace Common.BusinessLogic.AppIdAndAuth.Authorization
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.AppIdAndAuth.Authorization;

    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class ComplexEntityTools
    {
        public static ComplexEntity Read(long roleId, String cmpxEntName)
        {
            ComplexEntity result =
                DAL.CurrDBContext.Get().tblAuthorizationComplexEntity.Where(x => x.RoleId == roleId && x.ComplexEntityName == cmpxEntName).Select
                (
                    x =>
                    new ComplexEntity()
                    {
                        RoleId = x.RoleId,
                        ComplexEntityName = x.ComplexEntityName,
                        AllowMethodReadWithFilters = x.AllowMethodReadWithFilters
                    }
                ).Single();

            return result;
        }

        public static List<ComplexEntity> Read(long roleId)
        {
            List<ComplexEntity> result =
                DAL.CurrDBContext.Get().tblAuthorizationComplexEntity.Where(x => x.RoleId == roleId).Select
                (
                    x =>
                    new ComplexEntity()
                    {
                        RoleId = x.RoleId,
                        ComplexEntityName = x.ComplexEntityName,
                        AllowMethodReadWithFilters = x.AllowMethodReadWithFilters
                    }
                ).ToList();

            return result;
        }

        public static void Update(ComplexEntity app)
        {
            DAL.tblAuthorizationComplexEntity dataItem = DAL.CurrDBContext.Get().tblAuthorizationComplexEntity.
                Where( x => x.RoleId == app.RoleId && x.ComplexEntityName == app.ComplexEntityName ).Single();

            dataItem.AllowMethodReadWithFilters = app.AllowMethodReadWithFilters;
            DAL.CurrDBContext.Get().SaveChanges();
        }


        public static void Update(long roleId, List<ComplexEntity> appList)
        {
            List<DAL.tblAuthorizationComplexEntity> tableData =
                DAL.CurrDBContext.Get().tblAuthorizationComplexEntity.Where(x => x.RoleId == roleId).ToList();

            foreach (ComplexEntity currItem in appList)
            {
                var currTableItem = tableData.
                    Where( x => x.RoleId == currItem.RoleId && x.ComplexEntityName == currItem.ComplexEntityName ).SingleOrDefault();

                if (currTableItem == null)
                {
                    currTableItem = new DAL.tblAuthorizationComplexEntity()
                    {
                        RoleId = currItem.RoleId,
                        ComplexEntityName = currItem.ComplexEntityName,
                        AllowMethodReadWithFilters = currItem.AllowMethodReadWithFilters,
                    };

                    DAL.CurrDBContext.Get().tblAuthorizationComplexEntity.Add(currTableItem);
                }
                else
                {
                    currTableItem.RoleId = currItem.RoleId;
                    currTableItem.ComplexEntityName = currItem.ComplexEntityName;
                    currTableItem.AllowMethodReadWithFilters = currItem.AllowMethodReadWithFilters;
                }
            }

            DAL.CurrDBContext.Get().SaveChanges();
        }
    }
}
