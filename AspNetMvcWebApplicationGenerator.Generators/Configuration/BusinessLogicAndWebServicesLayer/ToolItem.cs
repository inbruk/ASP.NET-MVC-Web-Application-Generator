namespace AspNetMvcWebApplicationGenerator.Generators.Configuration.BusinessLogicAndWebServicesLayer
{
    using System;

    public class ToolItem
    {
        public String EntityName { get; }
        public ToolType ToolType { get; }

        #region link to other entities 
            public String OwnLinkedField { get; }
            public String ExternalLinkedTable { get; }
            public String ExternalLinkedField { get; }
        #endregion

        public ToolItem
        (
            String entityName,
            ToolType toolType,
            String ownLinkedField,
            String externalLinkedTable,
            String externalLinkedField
        )
        {
            EntityName = entityName;
            ToolType = toolType;
            OwnLinkedField = ownLinkedField;
            ExternalLinkedTable = externalLinkedTable;
            ExternalLinkedField = externalLinkedField;
        }
    }
}
