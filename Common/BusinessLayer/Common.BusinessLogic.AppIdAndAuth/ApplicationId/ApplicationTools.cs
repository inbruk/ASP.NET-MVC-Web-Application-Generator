namespace Common.WebServiceClient.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public enum enApplication
    {
        DirLangStrings = 1,
        ApplicationId = 2,
        Authentication = 3,
        Authorization = 4,
        Logging = 5,
        Engine = 6,
        WebApplication = 7,
        DriverMobileApp = 8
    };

    public static class ApplicationTools
    {
        private static Dictionary<enApplication, enProject> links =
            new Dictionary<enApplication, enProject>
            {
                { enApplication.DirLangStrings, enProject.Common },
                { enApplication.ApplicationId, enProject.Common },
                { enApplication.Authentication, enProject.Common },
                { enApplication.Authorization, enProject.Common },
                { enApplication.Logging, enProject.Common },
                { enApplication.Engine, enProject.WebAppExample },
                { enApplication.WebApplication, enProject.WebAppExample },
                { enApplication.DriverMobileApp, enProject.WebAppExample }
            };

        private static Application ConvertEnum(enApplication en)
        {
            long projectId = (long)(links[en]);
            Application result = new Application((long)(en), en.ToString(), projectId);
            return result;
        }

        private static Dictionary<long, Application> Applications { get; }

        static ApplicationTools()
        {
            Applications = new Dictionary<long, Application>();
            foreach (enApplication currEn in Enum.GetValues(typeof(enApplication)))
            {
                Application currItem = ConvertEnum(currEn);
                Applications.Add(currItem.Id, currItem);
            }
        }

        public static Application GetOneById(enApplication id)
        {
            Application result = Applications[(long)id];
            return result;
        }

        public static List<Application> GetAll()
        {
            var list = Applications.Values.ToList();
            return list;
        }
    }
}
