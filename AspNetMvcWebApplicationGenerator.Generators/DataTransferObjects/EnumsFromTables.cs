namespace AspNetMvcWebApplicationGenerator.Generators.DataTransferObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data;
    using System.Data.Entity;
    using System.Text;

    using Auxiliary.FileGeneration;
    using Auxiliary.PatternsAndClasses;

    using AspNetMvcWebApplicationGenerator.Configuration.DataTransferObjects;
    using AspNetMvcWebApplicationGenerator.Generators.DataTransferObjects;

    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    internal class EnumsFromTables
    {
        private void FillOneString(EnumItem currEnumItem, StringFileWriter fileWriter)
        {
            fileWriter.WriteString(currEnumItem.GetEnumRow());
        }

        private void FillOneFileItems(List<EnumItem> items, StringFileWriter fileWriter)
        {
            foreach (var currEnumItem in items)
                FillOneString(currEnumItem, fileWriter);
        }

        private void FillOneFile(List<EnumItem> items, String itemName)
        {
            String enName = "en" + itemName;

            StringFileWriter FileWriter = new StringFileWriter(
                DataTransferObjectsConfiguration.OutputPath, enName, OutputFileType.CSharpSource);

            FileWriter.WriteString("namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId ");
            FileWriter.WriteString("{ ");
            FileWriter.WriteString("    using System;");
            FileWriter.WriteString("    enum " + enName);
            FileWriter.WriteString("    { ");

            FillOneFileItems(items, FileWriter);

            FileWriter.WriteString("    } ");
            FileWriter.WriteString("} ");

            FileWriter.Close();
        }

        protected LazyInitWithoutParams<DAL.Common_AppIdAndAuth_Entities> CurrDBContext;
        private void ProcessOneEnum(EnumFromTable enumCfg)
        {
            List<EnumItem> data = CurrDBContext.Get().Database.SqlQuery<EnumItem>(
                "SELECT Id, EnumName FROM " + enumCfg.SourceTableName).ToList();

            FillOneFile(data, enumCfg.OutputTypeName);
        }

        public void Generate()
        {
            foreach (var item in DataTransferObjectsConfiguration.EnumFromTables)
                ProcessOneEnum(item);
        }
    }
}
