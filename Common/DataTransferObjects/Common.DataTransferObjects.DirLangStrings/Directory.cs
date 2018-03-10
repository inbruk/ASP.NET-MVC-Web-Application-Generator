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
        public Boolean IsDeleted { set; get; } = false;

        public Directory
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
    }
}
