namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class ComplexEntity // соответствует View в БД
    {
        public String  Name { get; }
        //public Boolean IsTableVeiw { get; }
        public String  MainEntityName { get; }
        public String  MainShortEntityName { get; }

        public List<ComplexEntityLink> Links { get; } 

        public ComplexEntity
        (
            String  name,
            //Boolean isTableVeiw,
            String  mainEntityName,
            String  mainShortEntityName,
            List<ComplexEntityLink> lnks
        )
        {
            Name                = name;
            //IsTableVeiw         = isTableVeiw;
            MainEntityName      = mainEntityName;
            MainShortEntityName = mainShortEntityName;
            Links               = lnks;
        }
    }
}
