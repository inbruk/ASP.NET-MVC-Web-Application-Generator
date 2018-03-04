namespace Common.BusinessLogicLayer.AppIdAndAuth.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public class LayerTools
        : BaseTools<DAL.Common_AppIdAndAuth_Entities, Layer> // для GetOneById() и GetAll()
    {
        protected override String _localStorageName { get { return "LayerTools_localInMemoryStorage"; } } // для StorageInMemAndPerApp<DT>

        private LayerTools()
        {
            if (StorageData == null) // если в хранилище нет данных, то грузим их
            {
                StorageData = DAL.CurrDBContext.Get().tblApplicationIdLayer.ToDictionary
                (
                    x => x.Id,
                    x => new Layer(x.Id, x.EnumName)
                );
            }
        }

#region Singleton
        private static readonly Lazy<LayerTools> instanceHolder = new Lazy<LayerTools>(() => new LayerTools());
        public static LayerTools Instance { get { return instanceHolder.Value; } }
#endregion Singleton
    }
}