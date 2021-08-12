namespace AspNetMvcWebApplicationGenerator.GeneratorsConfiguration.DataTransferObjects
{
    using System;
    using System.Collections.Generic;

    public static class DataTransferObjectsConfiguration
    {
        public static String OutputPath { set; get; }
        public static List<EnumFromTable> EnumFromTables { get; } = new List<EnumFromTable>();

        public static void AddEnum(EnumFromTable en2tab)
        {
            EnumFromTables.Add(en2tab);
        }
    }
}
