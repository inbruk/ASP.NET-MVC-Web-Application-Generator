namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class Directories
    {
        private void CreateTblDirectory()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "tblDirectory", OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE TABLE tblDirectory (");
            FileWriter.WriteString("    Id BIGINT, ");
            FileWriter.WriteString("    EnumName NVARCHAR(16) ");
            FileWriter.WriteString(");");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        private void CreateTblDirectoryValue()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "tblLanguage", OutputFileType.SqlScript);
            FileWriter.WriteString("CREATE TABLE tblLanguage (");
            FileWriter.WriteString("    Id BIGINT, ");
            FileWriter.WriteString("    EnumName NVARCHAR(16), ");
            FileWriter.WriteString("    UIName NVARCHAR(16) ");
            FileWriter.WriteString(");");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }


        private void FillOneTblDirectoryRow(LanguageItem currLangItem, StringFileWriter fileWriter)
        {
            //fileWriter.WriteString("");
            //fileWriter.WriteString("INSERT INTO tblLanguage ");
            //fileWriter.WriteString("    ( Id, EnumName, UIName )");
            //fileWriter.WriteString("VALUES");
            //fileWriter.WriteString("    ( " + currLangItem.Id.ToString() + ", " + currLangItem.EnumName + ", " + currLangItem.UIName + " );");
            //fileWriter.WriteString("GO");
        }

        public void Generate()
        {
            //CreateTables();

            //StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblDirectory", OutputFileType.SqlScript);
            //foreach (var currLanguage in DataConfiguration.DirectoryConfigurations.Values)
            //    FillOneTableRow(currLanguage, FileWriter);


            //FileWriter.Close();
        }
    }
}
