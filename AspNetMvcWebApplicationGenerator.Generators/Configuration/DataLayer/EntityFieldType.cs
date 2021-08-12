namespace AspNetMvcWebApplicationGenerator.Generators.Configuration.DataLayer
{
    public enum EntityFieldType
    {
        String = 10,
        // позже добавить поддержку
        //
        // String_Name = 11 
        // String_Name3FIO = 12 
        // String_SurnameAndInitials = 13
        // String_EMail = 14
        // String_URL = 15
        // String_IP = 16
        // String_TIN = 17
        // String_PassportNumber = 18
        // String_PassportSeries = 19
        // 
        // Ulong = 31, диапазонов
        // SInt = 32
        // UInt = 33

        SLong = 30,
        Float = 40,
        DateTime = 50,
        Boolean = 60,
        DecimalOrMoney = 70,
        DirectoryItem = 80,
        Link2TableOrVirtaulPart = 90
    }
}
