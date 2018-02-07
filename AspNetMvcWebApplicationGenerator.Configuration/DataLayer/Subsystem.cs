namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

