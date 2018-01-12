namespace AspNetMvcWebApplicationGenerator.Configuration.BusinessLogicAndWebServicesLayer
{
    using System.Collections.Generic;

    public class BLWSConfiguration
    {
        public List<ToolItem> tools { get; } 

        public BLWSConfiguration(List<ToolItem> toolsList)
        {
            tools = toolsList;
        }
    }
}
