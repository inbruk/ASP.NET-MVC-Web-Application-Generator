namespace AspNetMvcWebApplicationGenerator.Instantiate.Configuration
{
    using System;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Configuration.BusinessLogicAndWebServicesLayer;
    using AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer;

    using NDT  = AspNetMvcWebApplicationGenerator.Instance.Configuration.Data;
    using NBL  = AspNetMvcWebApplicationGenerator.Instance.Configuration.BusinessLogicAndWebService;
    using NWUI = AspNetMvcWebApplicationGenerator.Instance.Configuration.WebUserInterface;

    public static class CreateInstanceConfiguration
    {
        public static void Create
        (
            String dataLayerPath,
            String businessLayerPath,
            String servicesLayerPath,
            String presentationLayerPath
        )
        {
            DataConfiguration.OutputPath = "//Output//DataLayer";
            NDT.CreateLanguages.Create();
            NDT.CreateDirectories.Create();
            NDT.CreateEntities.Create();
            NDT.CreateComplexEntities.Create();

            BLWSConfiguration.BusinessLogicLayerOutputPath = "//Output//BusinessLogicLayer";
            BLWSConfiguration.ServicesLayerOutputPath = "//Output//ServicesLayer";
            NBL.CreateTools.Create();

            WUIConfiguration.OutputPath = "//Output/PresentationLayer";
            NWUI.CreateWebPage.Create();
        }
    }
}
