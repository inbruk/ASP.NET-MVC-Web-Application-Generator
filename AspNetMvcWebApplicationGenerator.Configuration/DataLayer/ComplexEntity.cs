namespace WebAppGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class ComplexEntity // соответствует View в БД
    {
        public String  Name { get; }
        public Boolean IsTableVeiw { get; }
        public String  MainTableName { get; }
        public String  MainShortTableName { get; }

        public ComplexEntity
        (
            String  name,
            Boolean isTableVeiw,
            String  mainTableName,
            String  mainShortTableName
        )
        {
            Name               = name;
            IsTableVeiw        = isTableVeiw;
            MainTableName      = mainTableName;
            MainShortTableName = mainShortTableName;
        }

        public List<ComplexEntityLink> Links { get; } = new List<ComplexEntityLink>();
        public void AddLink(ComplexEntityLink links)
        {
            Links.Add(links);
        }
    }
}
