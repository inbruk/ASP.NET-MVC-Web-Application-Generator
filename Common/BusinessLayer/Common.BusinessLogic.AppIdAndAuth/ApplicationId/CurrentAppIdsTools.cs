namespace Common.BusinessLogic.AppIdAndAuth.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Auxiliary.StorageTools;
    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;

    public class CurrentAppIdsTools : StorageInMemAndPerApp<ProjAppSubLayMeth> // для StorageData
    {
        public void Set(long subId, long layId, long metId )
        {
            if ( StorageData==null )
            {
                StorageData = new ProjAppSubLayMeth
                (
                    ProjAppSubTools.Instance.GetOneById(subId),
                    LayerTools.Instance.GetOneById(layId),
                    MethodTools.Instance.GetOneById(metId)
                );
            }
        }

        public ProjAppSubLayMeth Get()
        {
            return StorageData;
        }

#region Singleton
        private static readonly Lazy<CurrentAppIdsTools> instanceHolder = new Lazy<CurrentAppIdsTools>(() => new CurrentAppIdsTools());
        public static CurrentAppIdsTools Instance { get { return instanceHolder.Value; } }
#endregion Singleton
    }
}
