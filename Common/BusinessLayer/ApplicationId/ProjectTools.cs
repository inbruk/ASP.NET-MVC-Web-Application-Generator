namespace Common.BusinessLayer.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Common.DataTransferObjects.ApplicationId;
    using En = Common.DataTransferObjects.ApplicationId.Enums;

    public static class ProjectTools
    {
        public static Dictionary<En.Project, Project> Projects { get; }
        
        static ProjectTools()
        {
            Projects = new Dictionary<En.Project, Project>();

            foreach (var currEnItem in Enum.GetValues(typeof(En.Project)))
                Projects.Add( (En.Project)currEnItem, new Project((En.Project)currEnItem) ); 
        }
    }
}
