namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using System;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class Directories
    {
        private void CreateTblDirectory()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "tblDirectory", OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE TABLE tblDirectory (");
            FileWriter.WriteString("    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, ");
            FileWriter.WriteString("    EnumName NVARCHAR(16), ");
            FileWriter.WriteString("    IsReadOnly BIT ");
            FileWriter.WriteString(");");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        private void FillOneTblDirectoryRow(Directory dirItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("INSERT INTO tblDirectory ");
            fileWriter.WriteString("    ( Id, EnumName, IsReadOnly )");
            fileWriter.WriteString("VALUES");

            String IsReadOnlyStr = dirItem.IsReadOnly==true ? "1" : "0"; 
            fileWriter.WriteString("    ( " + dirItem.Id.ToString() + ", \'" + dirItem.EnumName + "\', " + IsReadOnlyStr + " );");
        }

        private void CreateTblDirectoryValue()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "tblDirectoryValue", OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE TABLE tblDirectoryValue (");
            FileWriter.WriteString("    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, ");
            FileWriter.WriteString("    EnumName NVARCHAR(16), ");
            FileWriter.WriteString("    IsReadOnly BIT, ");
            FileWriter.WriteString("    DirectoryId BIGINT FOREIGN KEY REFERENCES tblDirectory(Id)");            
            FileWriter.WriteString(");");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        private void CreateIndexes4TblDirectory()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "idxDirectoryValue", OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE INDEX idxDirectoryValue_DirectoryId ");
            FileWriter.WriteString("    ON tblDirectoryValue( DirectoryId ); ");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        private void FillOneTblDirectoryValue(DirectoryValue dirValue, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("INSERT INTO tblDirectoryValue ");
            fileWriter.WriteString("    ( Id, EnumName, IsReadOnly, DirectoryId )");
            fileWriter.WriteString("VALUES");

            String IsReadOnlyStr = dirValue.IsReadOnly == true ? "1" : "0";
            fileWriter.WriteString("    ( " + dirValue.Id.ToString() + ", \'" + dirValue.EnumName + "\', " 
                                            + IsReadOnlyStr + ", " + dirValue.DirectoryId.ToString() + " );");
        }
        
        private void CreateTblTranslatedString()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "tblTranslatedString", OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE TABLE tblTranslatedString (");
            FileWriter.WriteString("    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, ");
            FileWriter.WriteString("    Language BIGINT, ");
            FileWriter.WriteString("    Type INT, ");
            FileWriter.WriteString("    ReferencedItemId BIGINT, ");
            FileWriter.WriteString("    Value NVARCHAR(MAX) ");
            FileWriter.WriteString(");");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        private void CreateIndexes4TblTranslatedString()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "idxTranslatedString", OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE INDEX idxTranslatedString_Language ");
            FileWriter.WriteString("    ON tblTranslatedString( Language ); ");
            FileWriter.WriteString("GO");
            FileWriter.WriteString("");
            FileWriter.WriteString("CREATE INDEX idxTranslatedString_TypeRefId ");
            FileWriter.WriteString("    ON tblTranslatedString( Type, ReferencedItemId ); ");
            FileWriter.WriteString("GO");
            FileWriter.WriteString("");
            FileWriter.WriteString("CREATE INDEX idxTranslatedString_LangTypeRefId ");
            FileWriter.WriteString("    ON tblTranslatedString( Language, Type, ReferencedItemId ); ");
            FileWriter.WriteString("GO");
            FileWriter.WriteString("");
            FileWriter.Close();
        }

        private void FillOneTblTranslatedString(TranslatedString transStr, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("INSERT INTO tblTranslatedString ");
            fileWriter.WriteString("    ( Language, Type, ReferencedItemId, Value )");
            fileWriter.WriteString("VALUES");
            fileWriter.WriteString("    ( " + transStr.Language.ToString() + ", " + ((int)transStr.Type).ToString() + ", "
                                            + transStr.ReferencedItemId.ToString() + ", \'" + transStr.Value.ToString() + "\' );");
        }

        public void Generate()
        {
            CreateTblDirectory();

            CreateTblDirectoryValue();
            CreateIndexes4TblDirectory();

            CreateTblTranslatedString();
            CreateIndexes4TblTranslatedString();
            
            // заполняем словарными данными tblDirectory ------------------------------------------------------------------------------------------------
            StringFileWriter FileWriter_tblDirectory = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblDirectory", OutputFileType.SqlScript);
            FileWriter_tblDirectory.WriteString("");
            FileWriter_tblDirectory.WriteString("SET IDENTITY_INSERT tblDirectory ON;");
            FileWriter_tblDirectory.WriteString("");
            foreach (var currDirectory in DataConfiguration.DirectoryConfigurations.Values)
            {
                FillOneTblDirectoryRow(currDirectory, FileWriter_tblDirectory);
            }
            FileWriter_tblDirectory.WriteString("");
            FileWriter_tblDirectory.WriteString("SET IDENTITY_INSERT tblDirectory OFF;");
            FileWriter_tblDirectory.WriteString("GO");
            FileWriter_tblDirectory.Close();
            
            // заполняем словарными данными tblDirectoryValue -------------------------------------------------------------------------------------------
            StringFileWriter FileWriter_tblDirectoryValue = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblDirectoryValue", OutputFileType.SqlScript);
            FileWriter_tblDirectoryValue.WriteString("");
            FileWriter_tblDirectoryValue.WriteString("SET IDENTITY_INSERT tblDirectoryValue ON;");
            FileWriter_tblDirectoryValue.WriteString("");
            foreach (var currDirectory in DataConfiguration.DirectoryConfigurations.Values)
            {
                foreach (var currDirectoryValue in currDirectory.Items.Values)
                {
                    FillOneTblDirectoryValue(currDirectoryValue, FileWriter_tblDirectoryValue);
                }
            }
            FileWriter_tblDirectoryValue.WriteString("");
            FileWriter_tblDirectoryValue.WriteString("SET IDENTITY_INSERT tblDirectoryValue OFF;");
            FileWriter_tblDirectoryValue.WriteString("GO");
            FileWriter_tblDirectoryValue.Close();

            // заполняем словарными данными tblTranslatedString -----------------------------------------------------------------------------------------
            StringFileWriter FileWriter_tblTranslatedString = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblTranslatedString", OutputFileType.SqlScript);
            foreach (var currDirectory in DataConfiguration.DirectoryConfigurations.Values)
            {
                foreach (var currTranslatedString in currDirectory.TranslatedUINames)
                    FillOneTblTranslatedString(currTranslatedString, FileWriter_tblTranslatedString);

                foreach (var currDirectoryValue in currDirectory.Items.Values)
                {
                    foreach (var currTranslatedUIName in currDirectoryValue.TranslatedUINames)
                        FillOneTblTranslatedString(currTranslatedUIName, FileWriter_tblTranslatedString);

                    foreach (var currTranslatedUIComment in currDirectoryValue.TranslatedUIComments)
                        FillOneTblTranslatedString(currTranslatedUIComment, FileWriter_tblTranslatedString);
                }
            }
            FileWriter_tblTranslatedString.Close();

        }
    }
}
