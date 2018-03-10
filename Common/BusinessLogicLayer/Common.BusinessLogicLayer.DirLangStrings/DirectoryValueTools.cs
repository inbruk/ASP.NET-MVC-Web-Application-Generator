namespace Common.BusinessLogicLayer.DirLangStrings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.DirLangStrings;
    using Common.DataAccessLayer.DirLangStrings;

    public static class DirectoryValueTools
    {
        public static void Create1(DirectoryValue item)
        {
            tblDirectoryValue currItem = new tblDirectoryValue
            {
                DirectoryId = item.DirectoryId,
                EnumName = item.EnumName,
                IsReadOnly = item.IsReadOnly                
            };
            CurrDBContext.Get().tblDirectoryValue.Add(currItem);
            CurrDBContext.Get().SaveChanges();
        }

        public static DirectoryValue Read1(long currItemId)
        {
            DirectoryValue result = CurrDBContext.Get().tblDirectoryValue.Where( x => x.Id==currItemId ).
                Select( x => new DirectoryValue(x.Id, x.EnumName, x.IsReadOnly, x.DirectoryId) ).SingleOrDefault();

            return result;
        }

        public static List<DirectoryValue> ReadN(List<long> idList)
        {
            List<DirectoryValue> result = CurrDBContext.Get().tblDirectoryValue.Where(x => idList.Contains(x.Id)).
                Select( x => new DirectoryValue(x.Id, x.EnumName, x.IsReadOnly, x.DirectoryId) ).ToList();
            return result;
        }

        public static void Update1(DirectoryValue item)
        {
            tblDirectoryValue dataItem = CurrDBContext.Get().tblDirectoryValue.Where(x => x.Id == item.Id).Single();

            dataItem.EnumName = item.EnumName;
            dataItem.IsReadOnly = item.IsReadOnly;
            dataItem.IsDeleted = item.IsDeleted;
            dataItem.DirectoryId = item.DirectoryId;

            CurrDBContext.Get().SaveChanges();
        }

        public static void Delete1(long currItemId)
        {
            tblDirectoryValue dataItem = CurrDBContext.Get().tblDirectoryValue.Where(x => x.Id == currItemId).Single();
            dataItem.IsDeleted = true;
            CurrDBContext.Get().SaveChanges();
        }

        public static void UnDelete1(long currItemId)
        {
            tblDirectoryValue dataItem = CurrDBContext.Get().tblDirectoryValue.Where(x => x.Id == currItemId).Single();
            dataItem.IsDeleted = false;
            CurrDBContext.Get().SaveChanges();
        }
    }
}
