namespace AspNetMvcWebApplicationGenerator.Instantiate.Configuration
{
    using System;

    using AspNetMvcWebApplicationGenerator.Generators.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.Configuration.DataTransferObjects;
    using AspNetMvcWebApplicationGenerator.Generators.Configuration.BusinessLogicAndWebServicesLayer;
    using AspNetMvcWebApplicationGenerator.Generators.Configuration.WebUserInterfaceLayer;

    using NDT  = AspNetMvcWebApplicationGenerator.Instance.Configuration.Data;
    using DTO  = AspNetMvcWebApplicationGenerator.Instance.Configuration.DataTransferObjects;
    using NBL  = AspNetMvcWebApplicationGenerator.Instance.Configuration.BusinessLogicAndWebService;
    using NWUI = AspNetMvcWebApplicationGenerator.Instance.Configuration.WebUserInterface;

    public static class CreateInstanceConfiguration
    {
        public static void Create()
        {
            DataConfiguration.OutputPath = "c://temp//Output//DataLayer//";
            NDT.CreateLanguages.Create();
            NDT.CreateDirectories.Create();
            NDT.CreateEntities.Create();
            NDT.CreateComplexEntities.Create();

            DataTransferObjectsConfiguration.OutputPath = "c://temp//Output//DataTransferObjects//";
            DTO.CreateEnumsFromTables.Create();

            BLWSConfiguration.BusinessLogicLayerOutputPath = "c://temp//Output//BusinessLogicLayer//";
            NBL.CreateTools.Create();

            BLWSConfiguration.ServicesLayerOutputPath = "c://temp//Output//ServicesLayer//";

            WUIConfiguration.OutputPath = "c://temp//Output//PresentationLayer//";
            NWUI.CreateWebPage.Create();
        }
    }
}
