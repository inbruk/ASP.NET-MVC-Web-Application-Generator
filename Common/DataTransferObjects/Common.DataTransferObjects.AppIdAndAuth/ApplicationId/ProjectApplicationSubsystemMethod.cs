namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId
{
    using System;

    public class ProjectApplicationSubsystemMethod
    {
        public Project Project { get; }
        public Application Application { get; }
        public Subsystem Subsystem { get; }
        public Method Method { get; }

        public ProjectApplicationSubsystemMethod
        (
            Project proj,
            Application app,
            Subsystem sub,
            Method met
        )
        {
            Project = proj;
            Application = app;
            Subsystem = sub;
            Method = met;
        }
    }
}
