namespace Common.BusinessLogicLayer.AppIdAndAuth.Authorization
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.AppIdAndAuth.Authorization;

    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class ApplicationTools
    {
        public static Application Read(long roleId, long applicationId)
        {
            Application result =
                DAL.CurrDBContext.Get().tblAuthorizationApplication.Where( x => x.RoleId==roleId && x.ApplicationId==applicationId ).Select
                (
                    x =>
                    new Application()
                    {
                        RoleId = x.RoleId,
                        ApplicationId = x.ApplicationId,
                        AllowLogIn = x.AllowLogIn
                    }
                ).Single();

            return result;
        }

        public static List<Application> Read(long roleId)
        {
            List<Application> result =
                DAL.CurrDBContext.Get().tblAuthorizationApplication.Where( x => x.RoleId == roleId ).Select
                (
                    x =>
                    new Application()
                    {
                        RoleId = x.RoleId,
                        ApplicationId = x.ApplicationId,
                        AllowLogIn = x.AllowLogIn
                    }
                ).ToList();

            return result;
        }

        public static void Update(Application app)
        {
            DAL.tblAuthorizationApplication dataItem = DAL.CurrDBContext.Get().tblAuthorizationApplication.
                Where( x => x.RoleId == app.RoleId && x.ApplicationId == app.ApplicationId ).Single();

            dataItem.AllowLogIn = app.AllowLogIn;
            DAL.CurrDBContext.Get().SaveChanges();
        }


        public static void Update(long roleId, List<Application> appList)
        {
            List<DAL.tblAuthorizationApplication> tableData =
                DAL.CurrDBContext.Get().tblAuthorizationApplication.Where(x => x.RoleId == roleId).ToList();

            foreach(Application currItem in appList)
            {
                var currTableItem = tableData.
                    Where(x => x.RoleId == currItem.RoleId && x.ApplicationId == currItem.ApplicationId).SingleOrDefault();

                if( currTableItem==null )
                {
                    currTableItem = new DAL.tblAuthorizationApplication()
                    {
                        RoleId = currItem.RoleId,
                        ApplicationId = currItem.ApplicationId,
                        AllowLogIn = currItem.AllowLogIn                         
                    };

                    DAL.CurrDBContext.Get().tblAuthorizationApplication.Add(currTableItem);
                }
                else
                {
                    currTableItem.RoleId = currItem.RoleId;
                    currTableItem.ApplicationId = currItem.ApplicationId;
                    currTableItem.AllowLogIn = currItem.AllowLogIn;
                }
            }

            DAL.CurrDBContext.Get().SaveChanges();
        }
    }
}
