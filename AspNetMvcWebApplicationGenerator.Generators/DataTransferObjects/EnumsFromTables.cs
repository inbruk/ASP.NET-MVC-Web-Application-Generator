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
    using Auxiliary.StorageTools;

    using AspNetMvcWebApplicationGenerator.Configuration.DataTransferObjects;
    using AspNetMvcWebApplicationGenerator.Generators.DataTransferObjects;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using Common.BusinessLogic.AppIdAndAuth.ApplicationId;
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
            String enName = itemName;

            StringFileWriter FileWriter = new StringFileWriter(
                DataTransferObjectsConfiguration.OutputPath, enName, OutputFileType.CSharpSource);

            FileWriter.WriteString("namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId ");
            FileWriter.WriteString("{ ");
            FileWriter.WriteString("    using System;");
            FileWriter.WriteString("");
            FileWriter.WriteString("    public enum " + enName);
            FileWriter.WriteString("    { ");

            FillOneFileItems(items, FileWriter);

            FileWriter.WriteString("    } ");
            FileWriter.WriteString("} ");

            FileWriter.Close();
        }

        private List<EnumItem> GetEnumItemList(String tableName)
        {
            var ctx = new DAL.Common_AppIdAndAuth_Entities();
            var db = ctx.Database;
            var data = db.SqlQuery<EnumItem>("SELECT Id, EnumName FROM " + tableName).ToList();
            return data;
        }

        private void ProcessOneEnum(EnumFromTable enumCfg)
        {
            List<EnumItem> data = GetEnumItemList(enumCfg.SourceTableName);
            FillOneFile( data , enumCfg.OutputTypeName);
        }

        private void ProcessSystemEnum(EnumFromTable enumCfg)
        {
            List<ProjectApplicationSubsystem> items = ProjAppSubTools.Instance.GetAll();

            // convert to useful enum name
            List<EnumItem> result = new List<EnumItem>();
            foreach(var currItem in items)
            {
                EnumItem currResultItem = new EnumItem()
                {
                    Id = currItem.Subsystem.Id,
                    EnumName =
                        currItem.Project.EnumName + "_" +
                        currItem.Application.EnumName + "_" +
                        currItem.Subsystem.EnumName
                };
                result.Add(currResultItem);
            }

            FillOneFile(result, enumCfg.OutputTypeName);
        }

        public void Generate()
        {
            foreach (var item in DataTransferObjectsConfiguration.EnumFromTables)
                if (item.OutputTypeName.Contains("subsystem") || item.OutputTypeName.Contains("Subsystem"))
                    ProcessSystemEnum(item);
                else
                    ProcessOneEnum(item);
        }
    }
}
