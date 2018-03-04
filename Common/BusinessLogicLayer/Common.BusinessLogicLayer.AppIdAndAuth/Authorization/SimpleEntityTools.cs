namespace Common.BusinessLogicLayer.AppIdAndAuth.Authorization
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.AppIdAndAuth.Authorization;

    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class SimpleEntityTools
    {
        public static SimpleEntity Read(long roleId, long entityId)
        {
            SimpleEntity result =
                DAL.CurrDBContext.Get().tblAuthorizationSimpleEntity.Where(x => x.RoleId == roleId && x.EntityId == entityId).Select
                (
                    x =>
                    new SimpleEntity()
                    {
                        RoleId = x.RoleId,
                        EntityId = x.EntityId,                         
                        AllowMethodReadWithFilters = x.AllowMethodReadWithFilters,
                        AllowMethodCreateOne = x.AllowMethodCreateOne,
                        AllowMethodReadOne = x.AllowMethodReadOne,
                        AllowMethodUpdateOne = x.AllowMethodUpdateOne,
                        AllowMethodDeleteOne =  x.AllowMethodDeleteOne,
                        AllowMethodCreateMultiple = x.AllowMethodCreateMultiple,
                        AllowMethodReadMultiple = x.AllowMethodUpdateMultiple,
                        AllowMethodUpdateMultiple = x.AllowMethodUpdateMultiple,
                        AllowMethodDeleteMultiple = x.AllowMethodDeleteMultiple,
                        AllowMethodCreateLink = x.AllowMethodCreateLink,
                        AllowMethodReadLink = x.AllowMethodReadLink,
                        AllowMethodUpdateLink = x.AllowMethodUpdateLink,
                        AllowMethodDeleteLink = x.AllowMethodDeleteLink 
                    }
                ).Single();

            return result;
        }

        public static List<SimpleEntity> Read(long roleId)
        {
            List<SimpleEntity> result =
                DAL.CurrDBContext.Get().tblAuthorizationSimpleEntity.Where(x => x.RoleId == roleId).Select
                (
                    x =>
                    new SimpleEntity()
                    {
                        RoleId = x.RoleId,
                        EntityId = x.EntityId,
                        AllowMethodReadWithFilters = x.AllowMethodReadWithFilters,
                        AllowMethodCreateOne = x.AllowMethodCreateOne,
                        AllowMethodReadOne = x.AllowMethodReadOne,
                        AllowMethodUpdateOne = x.AllowMethodUpdateOne,
                        AllowMethodDeleteOne = x.AllowMethodDeleteOne,
                        AllowMethodCreateMultiple = x.AllowMethodCreateMultiple,
                        AllowMethodReadMultiple = x.AllowMethodUpdateMultiple,
                        AllowMethodUpdateMultiple = x.AllowMethodUpdateMultiple,
                        AllowMethodDeleteMultiple = x.AllowMethodDeleteMultiple,
                        AllowMethodCreateLink = x.AllowMethodCreateLink,
                        AllowMethodReadLink = x.AllowMethodReadLink,
                        AllowMethodUpdateLink = x.AllowMethodUpdateLink,
                        AllowMethodDeleteLink = x.AllowMethodDeleteLink
                    }
                ).ToList();

            return result;
        }

        public static void Update(SimpleEntity app)
        {
            DAL.tblAuthorizationSimpleEntity dataItem = DAL.CurrDBContext.Get().tblAuthorizationSimpleEntity.
                Where(x => x.RoleId == app.RoleId && x.EntityId == app.EntityId).Single();

            dataItem.AllowMethodReadWithFilters = app.AllowMethodReadWithFilters;
            dataItem.AllowMethodCreateOne = app.AllowMethodCreateOne;
            dataItem.AllowMethodReadOne = app.AllowMethodReadOne;
            dataItem.AllowMethodUpdateOne = app.AllowMethodUpdateOne;
            dataItem.AllowMethodDeleteOne = app.AllowMethodDeleteOne;
            dataItem.AllowMethodCreateMultiple = app.AllowMethodCreateMultiple;
            dataItem.AllowMethodReadMultiple = app.AllowMethodUpdateMultiple;
            dataItem.AllowMethodUpdateMultiple = app.AllowMethodUpdateMultiple;
            dataItem.AllowMethodDeleteMultiple = app.AllowMethodDeleteMultiple;
            dataItem.AllowMethodCreateLink = app.AllowMethodCreateLink;
            dataItem.AllowMethodReadLink = app.AllowMethodReadLink;
            dataItem.AllowMethodUpdateLink = app.AllowMethodUpdateLink;
            dataItem.AllowMethodDeleteLink = app.AllowMethodDeleteLink;

            DAL.CurrDBContext.Get().SaveChanges();
        }


        public static void Update(long roleId, List<SimpleEntity> appList)
        {
            List<DAL.tblAuthorizationSimpleEntity> tableData =
                DAL.CurrDBContext.Get().tblAuthorizationSimpleEntity.Where(x => x.RoleId == roleId).ToList();

            foreach (SimpleEntity currItem in appList)
            {
                var currTableItem = tableData.
                    Where(x => x.RoleId == currItem.RoleId && x.EntityId == currItem.EntityId).SingleOrDefault();

                if (currTableItem == null)
                {
                    currTableItem = new DAL.tblAuthorizationSimpleEntity()
                    {
                        RoleId = currItem.RoleId,
                        EntityId = currItem.EntityId,
                        AllowMethodReadWithFilters = currItem.AllowMethodReadWithFilters,                     
                        AllowMethodCreateOne = currItem.AllowMethodCreateOne,
                        AllowMethodReadOne = currItem.AllowMethodReadOne,
                        AllowMethodUpdateOne = currItem.AllowMethodUpdateOne,
                        AllowMethodDeleteOne = currItem.AllowMethodDeleteOne,
                        AllowMethodCreateMultiple = currItem.AllowMethodCreateMultiple,
                        AllowMethodReadMultiple = currItem.AllowMethodUpdateMultiple,
                        AllowMethodUpdateMultiple = currItem.AllowMethodUpdateMultiple,
                        AllowMethodDeleteMultiple = currItem.AllowMethodDeleteMultiple,
                        AllowMethodCreateLink = currItem.AllowMethodCreateLink,
                        AllowMethodReadLink = currItem.AllowMethodReadLink,
                        AllowMethodUpdateLink = currItem.AllowMethodUpdateLink,
                        AllowMethodDeleteLink = currItem.AllowMethodDeleteLink
                    };

                    DAL.CurrDBContext.Get().tblAuthorizationSimpleEntity.Add(currTableItem);
                }
                else
                {
                    currTableItem.RoleId = currItem.RoleId;
                    currTableItem.EntityId = currItem.EntityId;
                    currTableItem.AllowMethodReadWithFilters = currItem.AllowMethodReadWithFilters;
                    currTableItem.AllowMethodCreateOne = currItem.AllowMethodCreateOne;
                    currTableItem.AllowMethodReadOne = currItem.AllowMethodReadOne;
                    currTableItem.AllowMethodUpdateOne = currItem.AllowMethodUpdateOne;
                    currTableItem.AllowMethodDeleteOne = currItem.AllowMethodDeleteOne;
                    currTableItem.AllowMethodCreateMultiple = currItem.AllowMethodCreateMultiple;
                    currTableItem.AllowMethodReadMultiple = currItem.AllowMethodUpdateMultiple;
                    currTableItem.AllowMethodUpdateMultiple = currItem.AllowMethodUpdateMultiple;
                    currTableItem.AllowMethodDeleteMultiple = currItem.AllowMethodDeleteMultiple;
                    currTableItem.AllowMethodCreateLink = currItem.AllowMethodCreateLink;
                    currTableItem.AllowMethodReadLink = currItem.AllowMethodReadLink;
                    currTableItem.AllowMethodUpdateLink = currItem.AllowMethodUpdateLink;
                    currTableItem.AllowMethodDeleteLink = currItem.AllowMethodDeleteLink;
                }
            }

            DAL.CurrDBContext.Get().SaveChanges();
        }
    }
}
