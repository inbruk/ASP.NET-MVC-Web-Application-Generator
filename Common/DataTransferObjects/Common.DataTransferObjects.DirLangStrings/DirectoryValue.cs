namespace Common.DataTransferObjects.DirLangStrings
{
    using System;
    using System.Collections.Generic;

    public class DirectoryValue
    {
        public long Id { get; }
        public String EnumName { get; }
        public long DirectoryId { get; }
        public Boolean IsReadOnly { get; }
        public Boolean IsDeleted { set; get; } = false;

        public DirectoryValue
        (
            long id,
            String enumName,
            Boolean isReadOnly,
            long directoryId
        )
        {
            Id = id;
            EnumName = enumName;
            IsReadOnly = isReadOnly;
            DirectoryId = directoryId;
        }
    }
}
