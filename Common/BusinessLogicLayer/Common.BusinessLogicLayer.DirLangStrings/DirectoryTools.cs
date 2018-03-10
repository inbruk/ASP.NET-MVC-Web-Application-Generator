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
                Select(x => new Directory( id, x.EnumName, !!!!!!!!!!!!!!!!!!!!!! ).SingleOrDefault();

            return result;
        }

        public static List<Directory> Read(List<long> idList)
        {
            List<Directory> result = CurrDBContext.Get().tblDirectory.Where(x => idList.Contains(x.Id)).
                Select(x => new Directory((long)x.Language, (DirectoryType)x.Type, x.ReferencedItemId, x.Value)).ToList();
            return result;
        }

        public static void Update(Directory item)
        {
            tblDirectory dataItem = CurrDBContext.Get().tblDirectory.Where(x => x.Id == item.Id).Single();

            dataItem.Language = item.Language;
            dataItem.ReferencedItemId = item.ReferencedItemId;
            dataItem.Type = (int?)item.Type;
            dataItem.Value = item.Value;

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
