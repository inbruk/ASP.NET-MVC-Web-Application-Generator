namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.DataTransferObjects
{
    using System;

    using AspNetMvcWebApplicationGenerator.Configuration.DataTransferObjects;

    internal static class CreateEnumsFromTables
    {
        public static void Create()
        {
            DataTransferObjectsConfiguration.AddEnum(new EnumFromTable("tblApplicationIdProject", "enProject"));
            DataTransferObjectsConfiguration.AddEnum(new EnumFromTable("tblApplicationIdApplication", "enApplication"));
            DataTransferObjectsConfiguration.AddEnum(new EnumFromTable("tblApplicationIdSubsystem", "enSubsystem"));
            DataTransferObjectsConfiguration.AddEnum(new EnumFromTable("tblApplicationIdLayer", "enLayer"));
            DataTransferObjectsConfiguration.AddEnum(new EnumFromTable("tblApplicationIdMethod", "enMethod"));
        }
    }
}
