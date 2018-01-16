namespace AspNetMvcWebApplicationGenerator.Instantiate.Configuration
{
    using NDT  = AspNetMvcWebApplicationGenerator.Instance.Configuration.Data;
    using NBL  = AspNetMvcWebApplicationGenerator.Instance.Configuration.BusinessLogicAndWebService;
    using NWUI = AspNetMvcWebApplicationGenerator.Instance.Configuration.WebUserInterface;

    public static class CreateOverallConfiguration
    {
        public static void Create()
        {
            NDT.CreateLanguages.Create();
            NDT.CreateDirectories.Create();
            NDT.CreateEntities.Create();
            NDT.CreateComplexEntities.Create();

            NBL.CreateTools.Create();

            NWUI.CreateWebPage.Create();
        }
    }
}
