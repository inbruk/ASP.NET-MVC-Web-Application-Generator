namespace Common.DataTransferObjects.DirLangStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Directory
    {
        public long Id { get; }
        public String EnumName { get; }
        public Boolean IsReadOnly { get; }

        public List<TranslatedString> TranslatedUINames { get; }
        public Dictionary<String, DirectoryValue> Items { get; }

        public Directory
        (
            long id,
            String enumName,
            Boolean isReadOnly,
            List<TranslatedString> transUINames,
            List<DirectoryValue> items
        )
        {
            Id = id;
            EnumName = enumName;
            IsReadOnly = isReadOnly;
            TranslatedUINames = transUINames;

            Items = items.ToDictionary(x => x.EnumName, y => y);
        }
    }
}
