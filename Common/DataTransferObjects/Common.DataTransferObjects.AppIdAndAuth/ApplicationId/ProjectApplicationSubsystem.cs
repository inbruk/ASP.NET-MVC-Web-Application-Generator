namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId
{
    public class ProjectApplicationSubsystem
    {
        public Project Project { get; }
        public Application Application { get; }
        public Subsystem Subsystem { get; }

        public ProjectApplicationSubsystem() { ; }

        public ProjectApplicationSubsystem
        (
            Project proj,
            Application app,
            Subsystem sub
        )
        {
            Project = proj;
            Application = app;
            Subsystem = sub;
        }
    }
}
