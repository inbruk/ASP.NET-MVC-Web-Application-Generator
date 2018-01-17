namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Dl = AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

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

        protected String GenerateRowForStringFieldType(Dl.EntityField currField)
        {
            String strLength = currField.StringLengthMax.ToString();

            if (currField.StringLengthMax == 0)
                strLength = "MAX";

            String result = EmptyPrefix4 + currField.Name + " NVARCHAR(" + strLength + "),";

            return result;
        }

        protected String GenerateRowForSLongFieldType(Dl.EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " BIGINT,";
            return result;
        }

        protected String GenerateRowForFloatFieldType(Dl.EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " REAL,";
            return result;
        }

        protected String GenerateRowForDateTimeFieldType(Dl.EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " DATETIMEOFFSET,";
            return result;
        }

        protected String GenerateRowForBooleanFieldType(Dl.EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " BIT,";
            return result;
        }

        protected String GenerateRowForDecimalOrMoneyFieldType(Dl.EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " MONEY,";
            return result;
        }

        protected String GenerateRowForDirectoryItemFieldType(Dl.EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + " BIGINT FOREIGN KEY REFERENCES tblDictionaryValues(Id),";
            return result;
        }


        protected void WriteTableDefinitionRow(Dl.EntityField currField)
        {
            String str = "";
            switch (currField.FieldType)
            {
                case Dl.EntityFieldType.String:
                    str = GenerateRowForStringFieldType(currField);
                    break;
                case Dl.EntityFieldType.SLong:
                    str = GenerateRowForSLongFieldType(currField);
                    break;
                case Dl.EntityFieldType.Float:
                    str = GenerateRowForFloatFieldType(currField);
                    break;
                case Dl.EntityFieldType.DateTime:
                    str = GenerateRowForDateTimeFieldType(currField);
                    break;
                case Dl.EntityFieldType.Boolean:
                    str = GenerateRowForBooleanFieldType(currField);
                    break;
                case Dl.EntityFieldType.DecimalOrMoney:
                    str = GenerateRowForDecimalOrMoneyFieldType(currField);
                    break;
                case Dl.EntityFieldType.DirectoryItem:
                    str = GenerateRowForDirectoryItemFieldType(currField);
                    break;
                default:
                    // Внимание !!! сюда должны попадать сплошные списки без вложенных частей, без Dl.EntityFieldType.Link2TableOrVirtaulPart
                    throw new Exception("Error: FieldType has unsupported value !!!");
            }            

            FileWriter.WriteString(str);
        }

        public void GenerateFile(List<Dl.EntityField> fields)
        {
            // write header
            FileWriter.WriteString("CREATE TABLE " + TableName + " ( ");

            // write rows corresponding to 
            foreach (var currField in fields)
                WriteTableDefinitionRow(currField);

            // write tail
            FileWriter.WriteString(" ); ");

            // close file
            FileWriter.Close();
            FileWriter = null;
        }
    }
}
