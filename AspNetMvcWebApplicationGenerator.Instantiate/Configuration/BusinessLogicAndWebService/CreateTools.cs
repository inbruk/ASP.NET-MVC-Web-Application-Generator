namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.BusinessLogicAndWebService
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Generators.Configuration.BusinessLogicAndWebServicesLayer;

    public static class CreateTools
    {
        public static void Create()
        {
            BLWSConfiguration.AddTool(new ToolItem("Customer", ToolType.ReadNFilterAndSorting, null, null, null));
            BLWSConfiguration.AddTool(new ToolItem("Customer", ToolType.Crud1, null, null, null));

            BLWSConfiguration.AddTool(new ToolItem("Employee", ToolType.CrudN, null, null, null)); // пока для этого варианта wui не реализован !!!

            BLWSConfiguration.AddTool(new ToolItem("Driver", ToolType.ReadNFilterAndSorting, null, null, null));
            BLWSConfiguration.AddTool(new ToolItem("Driver", ToolType.Crud1, null, null, null));

            BLWSConfiguration.AddTool(new ToolItem("Vehicle",  ToolType.AttachDetach1toN, "DriverOwner", "Driver", "Id"));
            BLWSConfiguration.AddTool(new ToolItem("Order",    ToolType.AttachDetachMtoN, "Driver", "Driver", "Id"));

            BLWSConfiguration.AddTool(new ToolItem("OrderCustomer", ToolType.ReadNFilterAndSorting, null, null, null));
            BLWSConfiguration.AddTool(new ToolItem("OrderDriver",   ToolType.ReadNFilterAndSorting, null, null, null));
        }
    }
}
