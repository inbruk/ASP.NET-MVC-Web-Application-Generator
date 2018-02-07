namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Application
    {
        public long Id { get; }
        public String EnumName { get; }
        public long ProjectId { get; }

        public Application
        (
            long id,
            String enumName,
            long projectId
        )
        {
            Id = id;
            EnumName = enumName;
            ProjectId = projectId;
        }
    }
}
