namespace Common.BusinessLayer.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.ApplicationId;

    public static class ProjAppSubTools
    {
        private static Dictionary<long, ProjectApplicationSubsystem> _temp; 
                
        private static ProjectApplicationSubsystem _getBySubsystemId(long id) // only for internal use
        {
            Subsystem sub = SubsystemTools.GetOneById(id);
            Application app = ApplicationTools.GetOneById(sub.ApplicationId);
            Project prj = ProjectTools.GetOneById(app.ProjectId);

            ProjectApplicationSubsystem result = new ProjectApplicationSubsystem(prj, app, sub);

            return result;
        }

        static ProjAppSubTools() // fill temprary values 
        {
            _temp = new Dictionary<long, ProjectApplicationSubsystem>();

            List<Subsystem> list = SubsystemTools.GetAll();
            foreach(Subsystem currItem in list)
            {
                long subsId = currItem.Id;
                ProjectApplicationSubsystem value = _getBySubsystemId(subsId);
                _temp.Add(subsId, value);
            }
        }

        public static ProjectApplicationSubsystem GetBySubsystemId(long id)
        {
            ProjectApplicationSubsystem result = _temp[id];
            return result;
        }

        public static List<ProjectApplicationSubsystem> GetAll()
        {
            List<ProjectApplicationSubsystem> result = _temp.Values.ToList();
            return result;
        }
    }
}
