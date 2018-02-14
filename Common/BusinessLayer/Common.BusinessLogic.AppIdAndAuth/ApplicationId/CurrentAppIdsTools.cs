namespace Common.WebServiceClient.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class CurrentAppIdsTools
    {
        private static ProjectApplicationSubsystem _currentProjAppSub;
        public static ProjectApplicationSubsystem CurrentProjAppSub { get { return _currentProjAppSub; } }

        private static Layer _currentLayer;
        public static Layer CurrentLayer { get { return _currentLayer; } }

        public static void SetAllIds(enSubsystem sub, enLayer layer)
        {
            _currentProjAppSub = ProjAppSubTools.GetBySubsystemId(sub);
            _currentLayer = LayerTools.GetOneById(layer);
        }
    }
}
