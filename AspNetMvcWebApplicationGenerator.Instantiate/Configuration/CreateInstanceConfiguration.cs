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
        public static void Create()
        {
            DataConfiguration.OutputPath = "c://temp//Output//DataLayer//";

            NDT.CreateLanguages.Create();
            NDT.CreateDirectories.Create();
            NDT.CreateEntities.Create();
            NDT.CreateComplexEntities.Create();

            BLWSConfiguration.BusinessLogicLayerOutputPath = "c://temp//Output//BusinessLogicLayer//";
            BLWSConfiguration.ServicesLayerOutputPath = "c://temp//Output//ServicesLayer//";
            NBL.CreateTools.Create();

            WUIConfiguration.OutputPath = "c://temp//Output//PresentationLayer//";
            NWUI.CreateWebPage.Create();
        }
    }
}
