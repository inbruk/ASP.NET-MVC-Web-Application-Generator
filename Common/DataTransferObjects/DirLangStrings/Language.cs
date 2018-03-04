namespace Common.DataTransferObjects.DirLangStrings
{
    using System;

    public class Language
    {
        public long Id { get; }
        public String EnumName { get; }
        public String UIName { get; }

        public Language(long id, String enumName, String uiName)
        {
            Id = id;
            EnumName = enumName;
            UIName = uiName;
        }
    }
}
