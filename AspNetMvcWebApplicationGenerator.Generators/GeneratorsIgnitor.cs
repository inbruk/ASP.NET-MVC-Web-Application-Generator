namespace AspNetMvcWebApplicationGenerator.Generators
{
    using AspNetMvcWebApplicationGenerator.Instantiate.Configuration;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer;

    public static class GeneratorsIgnitor
    {
        public static void Ignite()
        {
            // initialize configuration ------------------

            CreateInstanceConfiguration.Create();

            // Data Layer --------------------------------
            ProjAppSubsLayerIds appIds = new ProjAppSubsLayerIds();
            appIds.Generate();

            Languages lng = new Languages();
            lng.Generate();

            Directories dir = new Directories();
            dir.Generate();

            Entities ent = new Entities();
            ent.Generate();

            ComplexEntities cEnt = new ComplexEntities();
            cEnt.Generate();


        }
    }
}
