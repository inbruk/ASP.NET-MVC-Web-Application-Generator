namespace Common.BusinessLogicLayer.DirLangStrings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.DirLangStrings;
    using Common.DataAccessLayer.DirLangStrings;

    public static class DirectoryTools
    {
        public static void Create(Directory item)
        {
            tblDirectory currItem = new tblDirectory
            {
                EnumName = item.EnumName,
                IsReadOnly = item.IsReadOnly                 
            };
            CurrDBContext.Get().tblDirectory.Add(currItem);
            CurrDBContext.Get().SaveChanges();
        }

        public static Directory Read(long id)
        {
            Directory result = CurrDBContext.Get().tblDirectory.Where(x => x.Id == id).
                Select(x => new Directory( x.Id, x.EnumName, x.IsReadOnly ) ).SingleOrDefault();

            return result;
        }

        public static List<Directory> Read(List<long> idList)
        {
            List<Directory> result = CurrDBContext.Get().tblDirectory.Where(x => idList.Contains(x.Id)).
                Select(x => new Directory(x.Id, x.EnumName, x.IsReadOnly) ).ToList();

            return result;
        }

        public static void Update(Directory item)
        {
            tblDirectory dataItem = CurrDBContext.Get().tblDirectory.Where(x => x.Id == item.Id).Single();

            dataItem.EnumName = item.EnumName;
            dataItem.IsReadOnly = item.IsReadOnly;
            dataItem.IsDeleted = item.IsDeleted;

            CurrDBContext.Get().SaveChanges();
        }

        public static void Delete(long id)
        {
            Directory curr = Read(id);
            curr.IsDeleted = true;
            Update(curr);
        }

        public static void UnDelete(long id)
        {
            Directory curr = Read(id);
            curr.IsDeleted = false;
            Update(curr);
        }
    }
}
