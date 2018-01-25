namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal static class RecursiveFromEntityFieldsExtractor
    {
        public static List<EntityField> Extract(Entity currEntity)
        {
            List<EntityField> result = new List<EntityField>();
            foreach (var currField in currEntity.Fields.Values)
            {
                if (currField.FieldType == EntityFieldType.Link2TableOrVirtaulPart && currField.LinkType == LinkType.One2OneVirtualPartOfObject)
                {
                    Entity linkedEntity = DataConfiguration.EntitiesConfigurations[currField.LinkedEntityName];
                    List<EntityField> tempFields = Extract(linkedEntity);
                    foreach (var currTempField in tempFields)
                    {
                        EntityField resultField = currTempField.CloneWithAdditionalNamePrefixAndVirtFlag(currField.Name);
                        result.Add(resultField);
                    }
                }
                else
                {
                    result.Add(currField);
                }
            }

            return result;
        }
    }
}
