namespace Common.WebServiceClient.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class ProjAppSubTools
    {
        private static Dictionary<long, ProjectApplicationSubsystemMethod> _temp; 
                
        private static ProjectApplicationSubsystemMethod _getBySubsystemId(enSubsystem id) // only for internal use
        {
            Subsystem sub = SubsystemTools.GetOneById(id);
            Application app = ApplicationTools.GetOneById((enApplication)sub.ApplicationId);
            Project prj = ProjectTools.GetOneById((enProject)app.ProjectId);

            ProjectApplicationSubsystemMethod result = null; // new ProjectApplicationSubsystemMethod(prj, app, sub, 0);

            // !!!!!!!!!!!!!!!!!!!!!!!!!!!1!!!!!!!!!!!!!!!!!!!!

            return result;
        }

        static ProjAppSubTools() // fill temprary values 
        {
            _temp = new Dictionary<long, ProjectApplicationSubsystemMethod>();

            List<Subsystem> list = SubsystemTools.GetAll();
            foreach(Subsystem currItem in list)
            {
                long subsId = currItem.Id;
                ProjectApplicationSubsystemMethod value = _getBySubsystemId( (enSubsystem)subsId );
                _temp.Add(subsId, value);
            }
        }

        public static ProjectApplicationSubsystemMethod GetBySubsystemId(enSubsystem id)
        {
            ProjectApplicationSubsystemMethod result = _temp[(long)id];
            return result;
        }

        public static List<ProjectApplicationSubsystemMethod> GetAll()
        {
            List<ProjectApplicationSubsystemMethod> result = _temp.Values.ToList();
            return result;
        }
    }
}
