namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId
{
    public class ProjAppSubLay
    {
        public Project Project { get; }
        public Application Application { get; }
        public Subsystem Subsystem { get; }
        public Layer Layer { get; }

        public ProjAppSubLay() { ; }

        public ProjAppSubLay
        (
            ProjectApplicationSubsystem pas,
            Layer lay
        )
        {
            Project = pas.Project;
            Application = pas.Application;
            Subsystem = pas.Subsystem;
            Layer = lay;
        }
    }
}
