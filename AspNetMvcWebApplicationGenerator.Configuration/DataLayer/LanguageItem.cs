namespace AspNetMvcWebApplicationGenerator.GeneratorsConfiguration.DataLayer
{
    using System;

    public class LanguageItem
    {
        public long Id { get; }
        public String EnumName { get; }
        public String UIName { get; }

        public LanguageItem(long id, String enumName, String uiName)
        {
            Id = id;
            EnumName = enumName;
            UIName = uiName;
        }
    }
}
