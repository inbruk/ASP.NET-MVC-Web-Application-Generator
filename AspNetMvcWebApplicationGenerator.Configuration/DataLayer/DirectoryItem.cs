namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class DirectoryItem
    {
        public long Id { get; }
        public String EnumName { get; }      
        public Boolean IsReadOnly { get; }

        public Dictionary<long, String> TranslatedUINames { get; } 
        public Dictionary<long, String> TranslatedUIComments { get; } 

        public DirectoryItem
        (
            long id,
            String enumName,
            Boolean isReadOnly,
            Dictionary<long, String> transUINames,
            Dictionary<long, String> transUIComments
        )
        {
            Id = id;
            EnumName = enumName;
            IsReadOnly = isReadOnly;
            TranslatedUINames = transUINames;
            TranslatedUIComments = transUIComments;
        }
    }
}
