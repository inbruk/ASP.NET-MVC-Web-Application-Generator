namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Layer
    {
        public long Id { get; }
        public String EnumName { get; }

        public Layer
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