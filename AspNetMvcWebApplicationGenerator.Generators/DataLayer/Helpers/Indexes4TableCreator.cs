namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    internal class Indexes4TableCreator
    {
        private const String EmptyPrefix4 = "    ";
        private String IndexFileName { get; }
        private StringFileWriter FileWriter = null;

        public Indexes4TableCreator(String filePath, String entityName)
        {
            IndexFileName = "idx" + entityName;
            FileWriter = new StringFileWriter(filePath, IndexFileName, OutputFileType.SqlScript);
        }

        public void GenerateFile(String entityName, List<EntityField> fields)
        {
            List<EntityField> fieldsWithIndexes = new List<EntityField>();
            foreach (var currField in fields)
            {
                if (currField.FieldType == EntityFieldType.DirectoryItem ||
                     (currField.FieldType == EntityFieldType.Link2TableOrVirtaulPart && currField.LinkType != LinkType.N2MTableOtherObject) ||
                     currField.GridColumnIsSortingAllowed == true ||
                     currField.FieldFilterIsRequired == true
                   )
                {
                    fieldsWithIndexes.Add(currField);
                }
            }

            FileWriter = new StringFileWriter(DataConfiguration.OutputPath, IndexFileName, OutputFileType.SqlScript);
            foreach (var currField in fieldsWithIndexes)
            {
                FileWriter.WriteString("CREATE INDEX " + IndexFileName + "_" + currField.Name + " ");
                FileWriter.WriteString(EmptyPrefix4 + "ON " + currField.LinkedEntityName + "(" + currField.LinkedFieldName + "); ");
                FileWriter.WriteString("GO");
                FileWriter.WriteString("");
            }
            FileWriter.Close();
        }
    }
}
