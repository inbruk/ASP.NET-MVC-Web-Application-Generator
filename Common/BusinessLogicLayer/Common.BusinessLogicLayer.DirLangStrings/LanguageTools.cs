namespace Common.BusinessLogicLayer.DirLangStrings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.DirLangStrings;
    using Common.DataAccessLayer.DirLangStrings;

    public static class LanguageTools
    {
        public static void Create(Language lng)
        {
            tblLanguage currItem = new tblLanguage
            {
                EnumName = lng.EnumName,
                UIName = lng.UIName
            };
            CurrDBContext.Get().tblLanguage.Add(currItem);
            CurrDBContext.Get().SaveChanges();
        }

        public static Language Read(long id)
        {
            Language result = CurrDBContext.Get().tblLanguage.Where(x => x.Id == id).
                Select( x => new Language(x.Id, x.EnumName, x.UIName) ).SingleOrDefault();
            return result;
        }

        public static List<Language> Read(List<long> idList)
        {
            List<Language> result = CurrDBContext.Get().tblLanguage.Where( x => idList.Contains(x.Id) ).
                Select( x => new Language(x.Id, x.EnumName, x.UIName) ).ToList();
            return result;
        }

        public static void Update(Language updLang)
        {
            tblLanguage dataItem = CurrDBContext.Get().tblLanguage.Where(x => x.Id == updLang.Id).Single();

            dataItem.EnumName = updLang.EnumName;
            dataItem.UIName = updLang.UIName;

            CurrDBContext.Get().SaveChanges();
        }

        public static void Delete(long id)
        {
            Language curr = Read(id);
            curr.IsDeleted = true;
            Update(curr);
        }

        public static void UnDelete(long id)
        {
            Language curr = Read(id);
            curr.IsDeleted = false;
            Update(curr);
        }
    }
}
