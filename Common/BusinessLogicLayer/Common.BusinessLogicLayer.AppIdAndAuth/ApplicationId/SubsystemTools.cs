namespace Common.BusinessLogicLayer.AppIdAndAuth.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public class SubsystemTools
        : BaseTools<DAL.Common_AppIdAndAuth_Entities, Subsystem> // для GetOneById() и GetAll()
    {
        protected override String _localStorageName { get { return "SubsystemTools_localInMemoryStorage"; } } // для StorageInMemAndPerApp<DT>

        private SubsystemTools()
        {
            if (StorageData == null) // если в хранилище нет данных, то грузим их
            {
                StorageData = DAL.CurrDBContext.Get().tblApplicationIdSubsystem.ToDictionary
                (
                    x => x.Id,
                    x => new Subsystem( x.Id, x.EnumName, x.ApplicationId )
                );
            }
        }

#region Singleton
        private static readonly Lazy<SubsystemTools> instanceHolder = new Lazy<SubsystemTools>(() => new SubsystemTools());
        public static SubsystemTools Instance { get { return instanceHolder.Value; } }
#endregion Singleton
    }
}
