namespace Common.DataTransferObjects.ApplicationId
{
    using System;

    public class Subsystem
    {
        public long Id { get; }
        public String EnumName { get; }
        public long ApplicationId { get; }

        public Subsystem
        (
            long id,
            String enumName,
            long applicationId
        )
        {
            Id = id;
            EnumName = enumName;
            ApplicationId = applicationId;
        }
    }
}
