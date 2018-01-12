namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class Directory
    {
        public String EnumName { get; }
        public Boolean IsReadOnly { get; }

        public Dictionary<long, String> TranslatedUINames { get; }
        public Dictionary<String, DirectoryItem> Items { get; } = new Dictionary<string, DirectoryItem>();
        
        public Directory
        ( 
            String enumName, 
            Boolean isReadOnly,
            Dictionary<long, String> transUINames,
            List<DirectoryItem> items
        )
        {
            EnumName = enumName;
            IsReadOnly = isReadOnly;
            TranslatedUINames = transUINames;

            foreach (var currItem in items)
                Items.Add(currItem.EnumName, currItem);
        }
    }
}
