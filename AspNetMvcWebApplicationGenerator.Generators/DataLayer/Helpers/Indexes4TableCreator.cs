namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers
{
    using System;
    using System.Collections.Generic;

    using Auxiliary.FileGeneration;
    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    internal class Indexes4TableCreator
    {
        private const String EmptyPrefix4 = "    ";
        private String _indexFileName = null;
        private StringFileWriter _fileWriter = null;
        private String _rootEntityName = null;

        public Indexes4TableCreator(String filePath, String entityName)
        {
            _rootEntityName = entityName;
            _indexFileName = "idx" + entityName;
            _fileWriter = new StringFileWriter(filePath, _indexFileName, OutputFileType.SqlScript);
        }

        public void GenerateFile(String entityName, List<EntityField> fields)
        {
            List<EntityField> fieldsWithIndexes = new List<EntityField>();
            foreach (var currField in fields)
            {
                if (currField.FieldType == EntityFieldType.DirectoryItem ||
                     (
                        currField.FieldType == EntityFieldType.Link2TableOrVirtaulPart && 
                        currField.LinkType != LinkType.N2MTableOtherObject && 
                        currField.LinkType != LinkType.One2OneVirtualPartOfObject
                     ) ||
                     currField.GridColumnIsSortingAllowed == true ||
                     currField.FieldFilterIsRequired == true
                   )
                {
                    fieldsWithIndexes.Add(currField);
                }
            }

            foreach (var currField in fieldsWithIndexes)
            {
                String idxEntityName, idxFieldName;
                if (currField.IsFieldOfVirtualNestedEntity == true ||
                    currField.FieldType == EntityFieldType.DirectoryItem || 
                    currField.FieldType == EntityFieldType.Link2TableOrVirtaulPart )
                {
                    idxEntityName = _rootEntityName;
                    idxFieldName = currField.Name;
                }
                else
                {
                    idxEntityName = currField.LinkedEntityName;
                    idxFieldName = currField.LinkedFieldName;
                }

                _fileWriter.WriteString("CREATE INDEX " + _indexFileName + "_" + currField.Name + " ");
                _fileWriter.WriteString(EmptyPrefix4 + "ON [tbl" + idxEntityName + "]([" + idxFieldName + "]); ");
                _fileWriter.WriteString("GO");
                _fileWriter.WriteString("");
            }
            _fileWriter.Close();
        }
    }
}
