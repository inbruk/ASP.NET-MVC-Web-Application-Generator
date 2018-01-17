namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    internal class TableCreator
    {
        private const String EmptyPrefix4 = "    ";
        private String TableName { get; }
        private StringFileWriter FileWriter = null;

        public TableCreator(String filePath, String entityName)
        {
            TableName = "tbl" + entityName;
            FileWriter = new StringFileWriter(filePath, TableName, OutputFileType.SqlScript);
        }

        protected String GenerateRowForStringFieldType(EntityField currField)
        {
            String strLength = currField.StringLengthMax.ToString();

            if (currField.StringLengthMax == 0)
                strLength = "MAX";

            String result = EmptyPrefix4 + currField.Name + " NVARCHAR(" + strLength + "),";

            return result;
        }

        protected String GenerateRowForSLongFieldType(EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " BIGINT,";
            return result;
        }

        protected String GenerateRowForFloatFieldType(EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " REAL,";
            return result;
        }

        protected String GenerateRowForDateTimeFieldType(EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " DATETIMEOFFSET,";
            return result;
        }

        protected String GenerateRowForBooleanFieldType(EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " BIT,";
            return result;
        }

        protected String GenerateRowForDecimalOrMoneyFieldType(EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " MONEY,";
            return result;
        }

        protected String GenerateRowForDirectoryItemFieldType(EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " BIGINT FOREIGN KEY REFERENCES tblDictionaryValues(Id),";
            return result;
        }


        protected void WriteTableDefinitionRow(EntityField currField)
        {
            String str = "";
            switch (currField.FieldType)
            {
                case EntityFieldType.String:
                    str = GenerateRowForStringFieldType(currField);
                    break;
                case EntityFieldType.SLong:
                    str = GenerateRowForSLongFieldType(currField);
                    break;
                case EntityFieldType.Float:
                    str = GenerateRowForFloatFieldType(currField);
                    break;
                case EntityFieldType.DateTime:
                    str = GenerateRowForDateTimeFieldType(currField);
                    break;
                case EntityFieldType.Boolean:
                    str = GenerateRowForBooleanFieldType(currField);
                    break;
                case EntityFieldType.DecimalOrMoney:
                    str = GenerateRowForDecimalOrMoneyFieldType(currField);
                    break;
                case EntityFieldType.DirectoryItem:
                    str = GenerateRowForDirectoryItemFieldType(currField);
                    break;
                default:
                    // Внимание !!! сюда должны попадать сплошные списки без вложенных частей, без Dl.EntityFieldType.Link2TableOrVirtaulPart
                    throw new Exception("Error: FieldType has unsupported value !!!");
            }            

            FileWriter.WriteString(str);
        }

        public void GenerateFile(List<EntityField> fields)
        {
            // write header
            FileWriter.WriteString("CREATE TABLE " + TableName + " ( ");

            // write rows corresponding to 
            foreach (var currField in fields)
                WriteTableDefinitionRow(currField);

            // write tail
            FileWriter.WriteString(" ); ");
            FileWriter.WriteString("GO");

            // close file
            FileWriter.Close();
            FileWriter = null;
        }
    }
}
