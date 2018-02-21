namespace Common.BusinessLogic.AppIdAndAuth.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public class ApplicationTools
        : BaseTools<DAL.Common_AppIdAndAuth_Entities, Application> // для GetOneById() и GetAll()
    {
        protected override String _localStorageName { get { return "ApplicationTools_localInMemoryStorage"; } } // для StorageInMemAndPerApp<DT>

        private ApplicationTools()
        {
            if (StorageData == null) // если в хранилище нет данных, то грузим их
            {
                StorageData = CurrDBContext.Get().tblApplicationIdApplication.ToDictionary
                (
                    x => x.Id,
                    x => new Application(x.Id, x.EnumName, x.ProjectId)
                );
            }
        }              

#region Singleton
        private static readonly Lazy<ApplicationTools> instanceHolder = new Lazy<ApplicationTools>(() => new ApplicationTools());
        public static ApplicationTools Instance { get { return instanceHolder.Value; } }
#endregion Singleton
    }
}
