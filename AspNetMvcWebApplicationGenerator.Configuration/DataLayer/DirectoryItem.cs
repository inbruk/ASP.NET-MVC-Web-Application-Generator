namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class DirectoryItem
    {
        public long Id { get; }
        public String EnumName { get; }      
        public Boolean IsReadOnly { get; }
        public DirectoryItem
        (
            long id,
            String enumName,
            Boolean isReadOnly
        )
        {
            Id = id;
            EnumName = enumName;
            IsReadOnly = isReadOnly;
        }

        public Dictionary<long, String> TranslatedUINames { get; } = new Dictionary<long, String>();
        public void AddTranslatedUINames(long langId, String name)
        {
            TranslatedUINames.Add(langId, name);
        }

        public Dictionary<long, String> TranslatedUIComments { get; } = new Dictionary<long, String>();
        public void AddTranslatedUIComments(long langId, String comment)
        {
            TranslatedUIComments.Add(langId, comment);
        }
    }
}
