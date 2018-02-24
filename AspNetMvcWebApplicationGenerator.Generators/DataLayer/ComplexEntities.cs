namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Auxiliary.FileGeneration;
    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class ComplexEntities
    {
        private Entity GetEntityByTableName(String tableName)
        {
            String entityName = tableName.Replace("tbl", "");
            Entity entity = DataConfiguration.EntitiesConfigurations[entityName];
            return entity;
        }

        private List<String> GenerateEntityFields(String tableName, String prefixName)
        {
            List<String> result = new List<String>();
            Entity entity = GetEntityByTableName(tableName);
            List<EntityField> fields = RecursiveFromEntityFieldsExtractor.Extract(entity);

            for(int i=0; i<fields.Count; i++)    
            {
                var currField = fields[i];
                if (currField.FieldType != EntityFieldType.Link2TableOrVirtaulPart)
                {
                    String fieldName = currField.Name;                    
                    String fieldString = prefixName + "." + fieldName + " AS " + prefixName + fieldName;

                    result.Add(fieldString);
                }
            }

            return result;
        }

        private List<String> ProcessLinkFields(ComplexEntity cmpxEntity)
        {
            List<String> result = new List<String>();
            List <ComplexEntityLink> linkFields = cmpxEntity.Links;

            foreach(var currLink in cmpxEntity.Links)
            {
                if (currLink.IsRightTableLink == false)
                {
                    List<String> currEntityFieldList = GenerateEntityFields(currLink.RightTableName, currLink.RightShortTableName);
                    result.AddRange(currEntityFieldList);
                }
            }

            return result;
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

            FileWriter.WriteString( joinStr + " [" + link.RightTableName + "] [" + link.RightShortTableName +
                "] ON [" + link.LeftShortTableName + "].[" + link.LeftFieldName + "]=[" + link.RightShortTableName + "].[" + link.RightFieldName + "]");
        }

        private void CreateOneViewForComplexEntity(ComplexEntity complexEntity)
        {
            String viewName = "vw" + complexEntity.Name;

            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, viewName, OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE VIEW " + viewName);
            FileWriter.WriteString("AS");

            FileWriter.WriteString("SELECT ");

            List<String> allFields = new List<string>();

            // получим все поля из основной сущности
            if( complexEntity.IsMainTableLink==false )            
                allFields.AddRange( GenerateEntityFields(complexEntity.MainEntityTableName, complexEntity.MainEntityShortName) );

            // получим все поля из связанных сущностей
            allFields.AddRange( ProcessLinkFields(complexEntity) );

            // сегенрируем поля в скрипте с учетом отсутствия запятой после последнего 
            for (int i = 0; i < allFields.Count; i++)
            {
                var currFieldStr = allFields[i];
                FileWriter.Write("    " + currFieldStr);
                if (i < allFields.Count - 1)
                    FileWriter.WriteString(",");
                else
                    FileWriter.WriteString("");
            }

            FileWriter.WriteString("FROM [" + complexEntity.MainEntityTableName + "] [" + complexEntity.MainEntityShortName + "] ");

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
