namespace AspNetMvcWebApplicationGenerator.Configuration.DataTransferObjects
{
    using System;

    public class EnumFromTable
    {
        public String SourceTableName { get; }
        public String OutputTypeName { get; } 

        public EnumFromTable(String srcTab, String outType)
        {
            SourceTableName = srcTab;
            OutputTypeName = outType;
        }
    }
}
