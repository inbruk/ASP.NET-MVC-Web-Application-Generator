namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using System;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class Directories
    {
        private void FillOneTblDirectoryRow(Directory dirItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("IF NOT EXISTS( SELECT * FROM tblDirectory WHERE Id=" + dirItem.Id.ToString() + " )");
            fileWriter.WriteString("BEGIN");
            fileWriter.WriteString("    INSERT INTO tblDirectory ");
            fileWriter.WriteString("        ( Id, EnumName, IsReadOnly )");
            fileWriter.WriteString("    VALUES");

            String IsReadOnlyStr = dirItem.IsReadOnly==true ? "1" : "0"; 
            fileWriter.WriteString("        ( " + dirItem.Id.ToString() + ", \'" + dirItem.EnumName + "\', " + IsReadOnlyStr + " );");
            fileWriter.WriteString("END");
        }

        private void FillOneTblDirectoryValue(DirectoryValue dirValue, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=" + dirValue.Id.ToString() + " )");
            fileWriter.WriteString("BEGIN");
            fileWriter.WriteString("    INSERT INTO tblDirectoryValue ");
            fileWriter.WriteString("        ( Id, EnumName, IsReadOnly, DirectoryId )");
            fileWriter.WriteString("    VALUES");

            String IsReadOnlyStr = dirValue.IsReadOnly == true ? "1" : "0";
            fileWriter.WriteString("    ( " + dirValue.Id.ToString() + ", \'" + dirValue.EnumName + "\', " 
                                            + IsReadOnlyStr + ", " + dirValue.DirectoryId.ToString() + " );");
            fileWriter.WriteString("END");
        }
        
        private void FillOneTblTranslatedString(TranslatedString transStr, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("IF NOT EXISTS( SELECT * FROM tblTranslatedString");
            fileWriter.WriteString("    WHERE Language=" + transStr.Language.ToString() + " AND Type=" + ((int)transStr.Type).ToString() + " AND ");
            fileWriter.WriteString("          ReferencedItemId=" + transStr.ReferencedItemId.ToString() + " AND Value=\'" + transStr.Value.ToString() + "\' )");
            fileWriter.WriteString("BEGIN");
            fileWriter.WriteString("    INSERT INTO tblTranslatedString ");
            fileWriter.WriteString("        ( Language, Type, ReferencedItemId, Value )");
            fileWriter.WriteString("    VALUES");
            fileWriter.WriteString("        ( " + transStr.Language.ToString() + ", " + ((int)transStr.Type).ToString() + ", "
                                                + transStr.ReferencedItemId.ToString() + ", \'" + transStr.Value.ToString() + "\' );");
            fileWriter.WriteString("END");
        }

        public void Generate()
        {
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
