namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class Languages
    {
        private void CreateTables()
        {
            StringFileWriter FileWriter = new StringFileWriter( DataConfiguration.OutputPath, "tblLanguage", OutputFileType.SqlScript );
            FileWriter.WriteString("CREATE TABLE tblLanguage (");
            FileWriter.WriteString("    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, ");
            FileWriter.WriteString("    EnumName NVARCHAR(16), ");
            FileWriter.WriteString("    UIName NVARCHAR(16) ");
            FileWriter.WriteString(");");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        private void FillOneTableRow(LanguageItem currLangItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("INSERT INTO tblLanguage ");
            fileWriter.WriteString("    ( Id, EnumName, UIName )");
            fileWriter.WriteString("VALUES");
            fileWriter.WriteString("    ( " + currLangItem.Id.ToString() + ", \'" + currLangItem.EnumName + "\', \'" + currLangItem.UIName + "\' );");
            fileWriter.WriteString("GO");
        }

        public void Generate()
        {
            CreateTables();

            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblLanguage", OutputFileType.SqlScript);
            foreach (var currLanguage in DataConfiguration.Languages.Values)
                FillOneTableRow( currLanguage, FileWriter );
            FileWriter.Close();
        }
    }
}
