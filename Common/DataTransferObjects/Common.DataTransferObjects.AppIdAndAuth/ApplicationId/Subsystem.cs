namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId
{
    using System;

    public class Subsystem : BaseItem
    {
        public long ApplicationId { get; }

        public Subsystem() { ; }
        public Subsystem(long id, String enumName, long applicationId)
            : base(id, enumName)
        {
            ApplicationId = applicationId;
        }
    }
}
