namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers
{
    using System;
    using System.Collections.Generic;

    using AuxiliaryTools.FileGeneration;
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
            String result = EmptyPrefix4 + currField.Name + " BIGINT";

            // если тип BIGINT и имя приводимо к id, то это главный ключ
            String fieldNameLowcase = currField.Name.ToLower(); 
            if ( fieldNameLowcase=="id" )
                result += " IDENTITY(1, 1) NOT NULL PRIMARY KEY";

            result += ", ";
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
            String result = EmptyPrefix4 + currField.Name + " BIGINT,";
            return result;
        }

        protected String GenerateRowForLinkOne2OneTable(EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name + 
                " BIGINT FOREIGN KEY REFERENCES tbl" + currField.LinkedEntityName + "(" + currField.LinkedFieldName + "),";
            return result;
        }

        protected String GenerateRowForLinkN2OneTable(EntityField currField)
        {
            String result = EmptyPrefix4 + currField.Name +
                " BIGINT FOREIGN KEY REFERENCES tbl" + currField.LinkedEntityName + "(" + currField.LinkedFieldName + "),";
            return result;
        }

        protected String  GenerateLinkTableForN2MLink(String entityName, EntityField currField)
        {
            String tableName = "n2m" + entityName + currField.LinkedEntityName;

            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, tableName, OutputFileType.SqlScript);
            FileWriter.WriteString( "CREATE TABLE " + tableName + "(" );
            FileWriter.WriteString( EmptyPrefix4 + "Id BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,");
            FileWriter.WriteString( EmptyPrefix4 + "[" + entityName + "]" + " BIGINT FOREIGN KEY REFERENCES tbl" + entityName + "(Id)," );
            FileWriter.WriteString( EmptyPrefix4 + "[" + currField.LinkedEntityName + "]" + " BIGINT FOREIGN KEY REFERENCES tbl" + currField.LinkedEntityName + "(Id)," );
            FileWriter.WriteString( ");" );
            FileWriter.WriteString( "GO" );
            FileWriter.Close();

            String indexFileName = "idx" + entityName + currField.LinkedEntityName;

            FileWriter = new StringFileWriter(DataConfiguration.OutputPath, indexFileName, OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE INDEX " + indexFileName + "_" + entityName + " ");
            FileWriter.WriteString(EmptyPrefix4 + "ON [" + tableName + "]([" + entityName + "]); ");
            FileWriter.WriteString("GO");
            FileWriter.WriteString("");
            FileWriter.WriteString("CREATE INDEX " + indexFileName + "_" + currField.LinkedEntityName + " ");
            FileWriter.WriteString(EmptyPrefix4 + "ON [" + tableName + "]([" + currField.LinkedEntityName + "]); ");
            FileWriter.WriteString("GO");
            FileWriter.Close();
            
            String result = EmptyPrefix4 + "-- see N2M link table n2m" + entityName + currField.LinkedEntityName;
            return result;
        }

        protected void WriteTableDefinitionRow(String entityName, EntityField currField)
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
                case EntityFieldType.DirectoryItem: // indexes generated in Indexes4TableCreator
                    str = GenerateRowForDirectoryItemFieldType(currField);
                    break;
                case EntityFieldType.Link2TableOrVirtaulPart:
                    switch (currField.LinkType)
                    {
                        case LinkType.One2OneTablePartOfObject: // indexes generated in Indexes4TableCreator
                            str = GenerateRowForLinkOne2OneTable(currField);
                            break;
                        case LinkType.N2OneTableOtherObject: // indexes generated in Indexes4TableCreator
                            str = GenerateRowForLinkN2OneTable(currField);
                            break;
                        case LinkType.N2MTableOtherObject: // link table and indexes generated here
                            str = GenerateLinkTableForN2MLink(entityName, currField);
                            break;
                        default:
                            throw new Exception("Error: LinkType has unsupported value !!!");
                    }
                    break;
                default:
                    throw new Exception("Error: FieldType has unsupported value !!!");
            }            

            FileWriter.WriteString(str);
        }

        public void GenerateFile(String entityName, List<EntityField> fields)
        {
            // write header
            FileWriter.WriteString("CREATE TABLE " + TableName + " ( ");

            // write rows corresponding to 
            foreach (var currField in fields)
                WriteTableDefinitionRow(entityName, currField);

            // write tail
            FileWriter.WriteString(" ); ");
            FileWriter.WriteString("GO");

            // close file
            FileWriter.Close();
            FileWriter = null;
        }
    }
}
