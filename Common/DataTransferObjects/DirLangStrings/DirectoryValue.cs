namespace Common.DataTransferObjects.DirLangStrings
{
    using System;
    using System.Collections.Generic;

    public class DirectoryValue
    {
        public long Id { get; }
        public String EnumName { get; }
        public Boolean IsReadOnly { get; }
        public long DirectoryId { get; }

        public List<TranslatedString> TranslatedUINames { get; }
        public List<TranslatedString> TranslatedUIComments { get; }

        public DirectoryValue
        (
            long id,
            String enumName,
            Boolean isReadOnly,
            long directoryId,

            List<TranslatedString> transUINames,
            List<TranslatedString> transUIComments
        )
        {
            Id = id;
            EnumName = enumName;
            IsReadOnly = isReadOnly;
            DirectoryId = directoryId;

            TranslatedUINames = transUINames;
            TranslatedUIComments = transUIComments;
        }
    }
}
