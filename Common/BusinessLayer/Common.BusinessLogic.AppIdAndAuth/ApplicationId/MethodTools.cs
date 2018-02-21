namespace Common.BusinessLogic.AppIdAndAuth.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public class MethodTools
        : BaseTools<DAL.Common_AppIdAndAuth_Entities, Method> // для GetOneById() и GetAll()
    {
        protected override String _localStorageName { get { return "MethodTools_localInMemoryStorage"; } } // для StorageInMemAndPerApp<DT>

        private MethodTools()
        {
            if (StorageData == null) // если в хранилище нет данных, то грузим их
            {
                StorageData = CurrDBContext.Get().tblApplicationIdMethod.ToDictionary
                (
                    x => x.Id,
                    x => new Method( x.Id, x.EnumName, x.SubsystemId, x.IsSpecial )
                );
            }
        }

#region Singleton
        private static readonly Lazy<MethodTools> instanceHolder = new Lazy<MethodTools>(() => new MethodTools());
        public static MethodTools Instance { get { return instanceHolder.Value; } }
#endregion Singleton
    }
}
