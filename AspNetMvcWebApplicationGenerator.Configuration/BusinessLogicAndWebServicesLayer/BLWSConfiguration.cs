namespace AspNetMvcWebApplicationGenerator.GeneratorsConfiguration.BusinessLogicAndWebServicesLayer
{
    using System;
    using System.Collections.Generic;

    public static class BLWSConfiguration
    {
        public static String BusinessLogicLayerOutputPath { set; get; }
        public static String ServicesLayerOutputPath { set; get; }

        public static List<ToolItem> tools { get; } = new List<ToolItem>();
        public static void AddTool(ToolItem tool)
        {
            tools.Add(tool);
        }
    }
}
