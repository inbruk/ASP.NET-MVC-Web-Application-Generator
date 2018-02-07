namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Project
    {
        public long Id { get; }
        public String EnumName { get; }

        public Project
        (
            long id,
            String enumName
        )
        {
            Id = id;
            EnumName = enumName;
        }
    }
}
