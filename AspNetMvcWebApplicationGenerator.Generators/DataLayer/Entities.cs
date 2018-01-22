namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class Entities
    {
        private List<EntityField> ExtractRowsFromEntityRecursively( Entity currEntity )
        {
            List<EntityField> result = new List<EntityField>();
            foreach( var currField in currEntity.Fields.Values )
            {
                if (currField.FieldType == EntityFieldType.Link2TableOrVirtaulPart && currField.LinkType == LinkType.One2OneVirtualPartOfObject)
                {
                    Entity linkedEntity = DataConfiguration.EntitiesConfigurations[currField.LinkedEntityName];
                    List<EntityField> tempFields = ExtractRowsFromEntityRecursively(linkedEntity);
                    foreach (var currTempField in tempFields)
                    {
                        EntityField resultField = currTempField.CloneWithAdditionalNamePrefix(currField.Name);
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

        private void CreateOneTableForEntity(Entity entity)
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "tblDirectory", OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE TABLE tblDirectory (");
            FileWriter.WriteString("    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, ");
            FileWriter.WriteString("    IsDeleted BIT NOT NULL DEFAULT 0;");

            List<EntityField> fields = ExtractRowsFromEntityRecursively(entity);
            TableCreator tc = new TableCreator(DataConfiguration.OutputPath, entity.Name);
            tc.GenerateFile(fields);

            FileWriter.WriteString(");");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }
    }
}
