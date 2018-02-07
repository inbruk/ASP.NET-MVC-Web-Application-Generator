namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer
{
    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers;

    internal class ProjAppSubsLayerIds
    {
        private void FillOneRow_tblProject(Project currItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("IF NOT EXISTS( SELECT * FROM tblProject WHERE Id=" + currItem.Id.ToString() + " )");
            fileWriter.WriteString("BEGIN");
            fileWriter.WriteString("    INSERT INTO tblProject ");
            fileWriter.WriteString("        ( Id, EnumName )");
            fileWriter.WriteString("    VALUES");
            fileWriter.WriteString("        ( " + currItem.Id.ToString() + ", \'" + currItem.EnumName + "\' );");
            fileWriter.WriteString("END");
        }

        private void Generate_tblProject()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblProject", OutputFileType.SqlScript);
            FileWriter.WriteString("SET IDENTITY_INSERT tblProject ON;");

            foreach (var currItem in DataConfiguration.Projects.Values)
                FillOneRow_tblProject(currItem, FileWriter);

            FileWriter.WriteString("SET IDENTITY_INSERT tblProject OFF;");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        private void FillOneRow_tblLayer(Layer currItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=" + currItem.Id.ToString() + " )");
            fileWriter.WriteString("BEGIN");
            fileWriter.WriteString("    INSERT INTO tblLayer ");
            fileWriter.WriteString("        ( Id, EnumName )");
            fileWriter.WriteString("    VALUES");
            fileWriter.WriteString("        ( " + currItem.Id.ToString() + ", \'" + currItem.EnumName + "\' );");
            fileWriter.WriteString("END");
        }

        private void Generate_tblLayer()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblLayer", OutputFileType.SqlScript);
            FileWriter.WriteString("SET IDENTITY_INSERT tblLayer ON;");

            foreach (var currItem in DataConfiguration.Layers.Values)
                FillOneRow_tblLayer(currItem, FileWriter);

            FileWriter.WriteString("SET IDENTITY_INSERT tblLayer OFF;");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        private void FillOneRow_tblApplication(Application currItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("IF NOT EXISTS( SELECT * FROM tblApplication WHERE Id=" + currItem.Id.ToString() + " )");
            fileWriter.WriteString("BEGIN");
            fileWriter.WriteString("    INSERT INTO tblApplication ");
            fileWriter.WriteString("        ( Id, EnumName, ProjectId )");
            fileWriter.WriteString("    VALUES");
            fileWriter.WriteString("        ( " + currItem.Id.ToString() + ", \'" + currItem.EnumName + "\', " + currItem.ProjectId.ToString() + " );");
            fileWriter.WriteString("END");
        }

        private void Generate_tblApplication()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblApplication", OutputFileType.SqlScript);
            FileWriter.WriteString("SET IDENTITY_INSERT tblApplication ON;");

            foreach (var currItem in DataConfiguration.Applications.Values)
                FillOneRow_tblApplication(currItem, FileWriter);

            FileWriter.WriteString("SET IDENTITY_INSERT tblApplication OFF;");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }


        private void FillOneRow_tblSubsystem(Subsystem currItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString("");
            fileWriter.WriteString("IF NOT EXISTS( SELECT * FROM tblSubsystem WHERE Id=" + currItem.Id.ToString() + " )");
            fileWriter.WriteString("BEGIN");
            fileWriter.WriteString("    INSERT INTO tblSubsystem ");
            fileWriter.WriteString("        ( Id, EnumName, ApplicationId)");
            fileWriter.WriteString("    VALUES");
            fileWriter.WriteString("        ( " + currItem.Id.ToString() + ", \'" + currItem.EnumName + "\', " + currItem.ApplicationId.ToString() + " );");
            fileWriter.WriteString("END");
        }

        private void Generate_tblSubsystem()
        {
            StringFileWriter FileWriter = new StringFileWriter(DataConfiguration.OutputPath, "fill_tblSubsystem", OutputFileType.SqlScript);
            FileWriter.WriteString("SET IDENTITY_INSERT tblSubsystem ON;");

            foreach (var currItem in DataConfiguration.Subsystems.Values)
                FillOneRow_tblSubsystem(currItem, FileWriter);

            FileWriter.WriteString("SET IDENTITY_INSERT tblSubsystem OFF;");
            FileWriter.WriteString("GO");
            FileWriter.Close();
        }

        public void Generate()
        {
            Generate_tblProject();
            Generate_tblLayer();
            Generate_tblApplication();
            Generate_tblSubsystem();
        }
    }
}
