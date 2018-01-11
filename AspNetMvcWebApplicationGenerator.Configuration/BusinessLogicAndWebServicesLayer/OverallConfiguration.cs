namespace WebAppGenerator.Configuration.BusinessLogicAndWebServicesLayer
{
    using System;
    using System.Collections.Generic;

    public class OverallConfiguration
    {
        public Dictionary< Tuple<String, ToolType>, ToolItem > tools { get; } = new Dictionary< Tuple<String, ToolType>, ToolItem >();
            
        public void AddTool(ToolItem tool)
        {
            var key = new Tuple<String, ToolType>( tool.EntityName, tool.ToolType );
            tools.Add(key, tool);
        }
    }
}
