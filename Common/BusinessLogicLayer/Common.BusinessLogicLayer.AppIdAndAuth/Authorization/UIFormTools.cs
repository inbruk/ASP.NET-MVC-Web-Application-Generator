namespace Common.BusinessLogicLayer.AppIdAndAuth.Authorization
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.AppIdAndAuth.Authorization;

    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class UIFormTools
    {
        public static UIForm ReadBySimpleEntity(long roleId, long entityId)
        {
            SimpleEntity simEnt = SimpleEntityTools.Read( roleId, entityId );
            UIForm result = new UIForm(simEnt);
            return result;
        }

        public static UIForm ReadByComplexEntity(long roleId, String ComplexEntityName)
        {
            ComplexEntity simEnt = ComplexEntityTools.Read(roleId, ComplexEntityName);
            UIForm result = new UIForm(simEnt);
            return result;
        }

        public static List<UIForm> ReadBySimpleEntities(long roleId)
        {
            List<SimpleEntity> simEntList = SimpleEntityTools.Read(roleId);
            List<UIForm> result = simEntList.Select( x => new UIForm(x) ).ToList();           
            return result;
        }

        public static List<UIForm> ReadByComplexEntities(long roleId)
        {
            List<ComplexEntity> cplxEntList = ComplexEntityTools.Read(roleId);
            List<UIForm> result = cplxEntList.Select(x => new UIForm(x)).ToList();
            return result;
        }
    }
}
