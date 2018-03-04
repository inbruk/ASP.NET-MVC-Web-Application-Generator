namespace Common.BusinessLogicLayer.AppIdAndAuth.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public class ProjAppSubTools
        : BaseTools<DAL.Common_AppIdAndAuth_Entities, ProjectApplicationSubsystem> // для GetOneById() и GetAll()
    {
        protected override String _localStorageName { get { return "ProjAppSubTools_localInMemoryStorage"; } } // для StorageInMemAndPerApp<DT>

        private ProjectTools projectTools;
        private ApplicationTools applicationTools;
        private SubsystemTools subsystemTools;
        
        private ProjectApplicationSubsystem _getBySubsystemId(long id) // only for internal use
        {
            Subsystem sub = subsystemTools.GetOneById(id);
            Application app = applicationTools.GetOneById(sub.ApplicationId);
            Project prj = projectTools.GetOneById(app.ProjectId);

            ProjectApplicationSubsystem result =  new ProjectApplicationSubsystem(prj, app, sub);

            return result;
        }

        private ProjAppSubTools()  
        {
            projectTools     = ProjectTools.Instance;
            applicationTools = ApplicationTools.Instance;
            subsystemTools   = SubsystemTools.Instance;

            if (StorageData == null)
            {
                List<Subsystem> list = subsystemTools.GetAll();
                Dictionary<long, ProjectApplicationSubsystem> dataToStore = new Dictionary<long, ProjectApplicationSubsystem>();
                foreach (Subsystem currItem in list)
                {
                    long subsId = currItem.Id;
                    ProjectApplicationSubsystem value = _getBySubsystemId(subsId);
                    dataToStore.Add(subsId, value);
                }

                StorageData = dataToStore;
            }
        }

#region Singleton
        private static readonly Lazy<ProjAppSubTools> instanceHolder = new Lazy<ProjAppSubTools>(() => new ProjAppSubTools());
        public static ProjAppSubTools Instance { get { return instanceHolder.Value; } }
#endregion Singleton
    }
}
