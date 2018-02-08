namespace Common.DataTransferObjects.ApplicationId
{
    using System;

    public class ProjectApplicationSubsystem
    {
        public Project project { get; }
        public Application application { get; }
        public Subsystem subsystem { get; }

        public ProjectApplicationSubsystem
        (
            Project proj,
            Application app,
            Subsystem sub            
        )
        {
            project = proj;
            application = app;
            subsystem = sub;
        }
    }
}
