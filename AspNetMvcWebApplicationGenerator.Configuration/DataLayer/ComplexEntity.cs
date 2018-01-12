namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class ComplexEntity // соответствует View в БД
    {
        public String  Name { get; }
        public Boolean IsTableVeiw { get; }
        public String  MainTableName { get; }
        public String  MainShortTableName { get; }

        public List<ComplexEntityLink> Links { get; } 

        public ComplexEntity
        (
            String  name,
            Boolean isTableVeiw,
            String  mainTableName,
            String  mainShortTableName,
            List<ComplexEntityLink> lnks
        )
        {
            Name               = name;
            IsTableVeiw        = isTableVeiw;
            MainTableName      = mainTableName;
            MainShortTableName = mainShortTableName;
            Links              = lnks;
        }
    }
}
