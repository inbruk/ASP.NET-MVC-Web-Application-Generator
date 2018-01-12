namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class Directory
    {
        public String EnumName { get; }
        public Boolean IsReadOnly { get; }
        public Directory( String enumName, Boolean isReadOnly )
        {
            EnumName = enumName;
            IsReadOnly = isReadOnly;
        }

        public Dictionary<long, String> TranslatedUIName { get; } = new Dictionary<long, String>();
        public void AddTranslatedUIName(long langId, String name)
        {
            TranslatedUIName.Add(langId, name);
        }

        public Dictionary<String, DirectoryItem> Items { get; } = new Dictionary<String, DirectoryItem>();
        public void AddItem(DirectoryItem item)
        {
            String enumName = item.EnumName;
            Items.Add(enumName, item);
        }
    }
}
