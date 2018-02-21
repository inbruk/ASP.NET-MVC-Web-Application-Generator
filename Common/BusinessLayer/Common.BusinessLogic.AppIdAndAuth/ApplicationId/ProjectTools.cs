namespace Common.BusinessLogic.AppIdAndAuth.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public class ProjectTools 
        : BaseTools<DAL.Common_AppIdAndAuth_Entities, Project> // для GetOneById() и GetAll()
    {
        protected override String _localStorageName { get { return "ProjectTools_localInMemoryStorage"; } } // для StorageInMemAndPerApp<DT>

        private ProjectTools()
        {
            if ( StorageData == null ) // если в хранилище нет данных, то грузим их
            {
                StorageData = CurrDBContext.Get().tblApplicationIdProject.ToDictionary
                (
                    x => x.Id, 
                    x => new Project(x.Id, x.EnumName)                    
                );
            }
        }

#region Singleton
        private static readonly Lazy<ProjectTools> instanceHolder = new Lazy<ProjectTools>(() => new ProjectTools());
        public static ProjectTools Instance { get { return instanceHolder.Value; } }
#endregion Singleton
    }
}
