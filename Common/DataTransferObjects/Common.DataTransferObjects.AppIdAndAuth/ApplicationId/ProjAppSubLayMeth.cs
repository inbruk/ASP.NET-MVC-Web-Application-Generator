namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId
{
    public class ProjAppSubLayMeth
    {
        public Project Project { get; }
        public Application Application { get; }
        public Subsystem Subsystem { get; }
        public Layer Layer { get; }
        public Method Method { get; }

        public ProjAppSubLayMeth() { ; }        

        public ProjAppSubLayMeth
        (
            ProjectApplicationSubsystem pas,
            Layer lay,
            Method met
        )
        {
            Project = pas.Project;
            Application = pas.Application;
            Subsystem = pas.Subsystem;
            Layer = lay;
            Method = met;
        }
    }
}
