namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using Auxiliary.FileGeneration;
    using AspNetMvcWebApplicationGenerator.Generators.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class Languages
    {
        private void FillOneTableRow(LanguageItem currLangItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("IF NOT EXISTS( SELECT * FROM tblLanguage WHERE Id=" + currLangItem.Id.ToString() + " )");
            fileWriter.WriteString("BEGIN");
            fileWriter.WriteString("    INSERT INTO tblLanguage ");
            fileWriter.WriteString("        ( Id, EnumName, UIName )");
            fileWriter.WriteString("    VALUES");
            fileWriter.WriteString("        ( " + currLangItem.Id.ToString() + ", \'" + currLangItem.EnumName + "\', \'" + currLangItem.UIName + "\' );");
            fileWriter.WriteString("END");
        }

        public void Generate()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblLanguage", OutputFileType.SqlScript);
            FileWriter.WriteString("SET IDENTITY_INSERT tblLanguage ON;");

            foreach (var currLanguage in DataConfiguration.Languages.Values)
                FillOneTableRow( currLanguage, FileWriter );

            FileWriter.WriteString("SET IDENTITY_INSERT tblLanguage OFF;");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }
    }
}
