﻿namespace AspNetMvcWebApplicationGenerator.Configuration.BusinessLogicAndWebServicesLayer
{
    using System.Collections.Generic;

    public static class BLWSConfiguration
    {
        public static List<ToolItem> tools { get; } = new List<ToolItem>();
        public static void AddTool(ToolItem tool)
        {
            tools.Add(tool);
        }
    }
}