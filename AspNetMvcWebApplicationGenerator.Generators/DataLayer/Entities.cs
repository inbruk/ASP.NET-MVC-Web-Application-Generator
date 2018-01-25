namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class Entities
    {
        private void CreateOneTableForEntity(Entity entity)
        {
            List<EntityField> fields = RecursiveFromEntityFieldsExtractor.Extract(entity);

            // create table by field list
            TableCreator tc = new TableCreator(DataConfiguration.OutputPath, entity.Name);
            tc.GenerateFile(entity.Name, fields);

            // create indexes by field list
            Indexes4TableCreator ic = new Indexes4TableCreator(DataConfiguration.OutputPath, entity.Name);
            ic.GenerateFile(entity.Name, fields);
        }

        public void Generate()
        {
            foreach (var currEntity in DataConfiguration.EntitiesConfigurations.Values)
                if( currEntity.Type != EntityType.VirtualPartOfObject )
                    CreateOneTableForEntity(currEntity);
        }
    }
}
