namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class ComplexEntities
    {
        private void GenerateEntityFields(String entityName, StringFileWriter FileWriter, String prefixName, Boolean addPrefixName)
        {
            Entity entity = DataConfiguration.EntitiesConfigurations[entityName];
            List<EntityField> fields = RecursiveFromEntityFieldsExtractor.Extract(entity);
            foreach (var currField in fields)
            {
                String fieldName = currField.Name;
                if (addPrefixName == true)
                    fieldName = prefixName + fieldName;

                FileWriter.WriteString("    " + fieldName + ", ");
            }
        }

        private void GenerateJoinClause(ComplexEntityLink link, StringFileWriter FileWriter)
        {
            String joinStr = "";
            switch (link.Type)
            {
                case ComplexEntityLinkType.Inner:
                    joinStr = "INNER JOIN";
                    break;
                case ComplexEntityLinkType.Left:
                    joinStr = "LEFT JOIN";
                    break;
                case ComplexEntityLinkType.Right:
                    joinStr = "RIGHT JOIN";
                    break;
            }

            FileWriter.WriteString( joinStr + "tbl" + link.RightTableName + " " + link.RightShortTableName +
                " ON " + link.LeftShortTableName + "." + link.LeftFieldName + "=" + link.RightShortTableName + "." + link.RightFieldName );
        }

        private void CreateOneViewForComplexEntity(ComplexEntity complexEntity)
        {
            String viewName = "vw" + complexEntity.Name;

            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, viewName, OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE VIEW " + viewName);
            FileWriter.WriteString("AS");

            FileWriter.WriteString("SELECT ");
            GenerateEntityFields(complexEntity.MainEntityName, FileWriter, "", false);
            FileWriter.WriteString("FROM tbl" + complexEntity.MainEntityName + " " + complexEntity.MainShortEntityName );

            foreach (var currLink in complexEntity.Links)
                GenerateJoinClause(currLink, FileWriter);
                    
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        public void Generate()
        {
            foreach (var currComplexEntity in DataConfiguration.ComplexEntitiesConfigurations.Values)
                CreateOneViewForComplexEntity(currComplexEntity);
        }
    }
}
