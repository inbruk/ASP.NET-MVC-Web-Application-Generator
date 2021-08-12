namespace AspNetMvcWebApplicationGenerator.Generators.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class ComplexEntity // соответствует View в БД
    {
        public String  Name { get; }
        public Boolean IsMainTableLink { get; }
        public String  MainEntityTableName { get; }
        public String  MainEntityShortName { get; }

        public List<ComplexEntityLink> Links { get; } 

        public ComplexEntity
        (
            String  name,
            Boolean isMainTableLink,
            String  mainEntityTableName,
            String  mainEntityShortName,
            List<ComplexEntityLink> lnks
        )
        {
            Name                = name;
            IsMainTableLink     = isMainTableLink;
            MainEntityTableName = mainEntityTableName;
            MainEntityShortName = mainEntityShortName;
            Links               = lnks;
        }
    }
}
