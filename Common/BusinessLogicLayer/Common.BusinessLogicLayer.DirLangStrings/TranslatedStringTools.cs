namespace Common.BusinessLogicLayer.DirLangStrings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.DirLangStrings;
    using Common.DataAccessLayer.DirLangStrings;

    public static class TranslatedStringTools
    {
        public static void Create1(TranslatedString item)
        {
            tblTranslatedString currItem = new tblTranslatedString
            {
                Language = item.Language,
                ReferencedItemId = item.ReferencedItemId,
                Type = (int) item.Type,
                Value = item.Value
 
            };
            CurrDBContext.Get().tblTranslatedString.Add(currItem);
            CurrDBContext.Get().SaveChanges();
        }

        public static void CreateN(List<TranslatedString> itemList)
        {
            foreach (TranslatedString currItem in itemList)
            {
                tblTranslatedString currNewItem = new tblTranslatedString
                {
                    Language = currItem.Language,
                    ReferencedItemId = currItem.ReferencedItemId,
                    Type = (int) currItem.Type,
                    Value = currItem.Value

                };
                CurrDBContext.Get().tblTranslatedString.Add(currNewItem);
            }
            CurrDBContext.Get().SaveChanges();
        }

        public static List<TranslatedString> ReadWithFilter(long referencedItemId, TranslatedStringType type)
        {
            List<TranslatedString> result = CurrDBContext.Get().tblTranslatedString.Where( x => x.ReferencedItemId==referencedItemId && x.Type==(int)type ).
                Select(x => new TranslatedString(x.Id, (long)x.Language, (TranslatedStringType)x.Type, x.ReferencedItemId, x.Value)).ToList();

            return result;
        }

        public static TranslatedString Read1(long id)
        {
            TranslatedString result = CurrDBContext.Get().tblTranslatedString.Where(x => x.Id == id).
                Select( x => new TranslatedString( x.Id, (long)x.Language, (TranslatedStringType) x.Type, x.ReferencedItemId, x.Value ) ).SingleOrDefault();

            return result;
        }

        public static List<TranslatedString> ReadN(List<long> idList)
        {
            List<TranslatedString> result = CurrDBContext.Get().tblTranslatedString.Where(x => idList.Contains(x.Id)).
                Select( x => new TranslatedString( x.Id, (long)x.Language, (TranslatedStringType)x.Type, x.ReferencedItemId, x.Value) ).ToList();
            return result;
        }

        public static void Update1(TranslatedString item)
        {
            tblTranslatedString dataItem = CurrDBContext.Get().tblTranslatedString.Where( x => x.Id == item.Id ).Single();

            dataItem.Language = item.Language;
            dataItem.ReferencedItemId = item.ReferencedItemId;
            dataItem.Type = (int) item.Type;
            dataItem.Value = item.Value;

            CurrDBContext.Get().SaveChanges();
        }

        public static void UpdateN(List<TranslatedString> itemList)
        {
            List<long> idList = itemList.Select(x => x.Id).ToList();
            List<tblTranslatedString> tableItemsList = CurrDBContext.Get().tblTranslatedString.Where(x => idList.Contains(x.Id)).ToList();

            foreach(tblTranslatedString currTableItem in tableItemsList)
            {
                var currNewItem = itemList.SingleOrDefault(x => x.Id == currTableItem.Id);
                if( currNewItem!=null )
                {
                    currTableItem.Language = currNewItem.Language;
                    currTableItem.ReferencedItemId = currNewItem.ReferencedItemId;
                    currTableItem.Type = (int) currNewItem.Type;
                    currTableItem.Value = currNewItem.Value;
                }
            }

            CurrDBContext.Get().SaveChanges();
        }

        public static void Delete1(long id)
        {
            TranslatedString curr = Read1(id);
            curr.IsDeleted = true;
            Update1(curr);
        }

        public static void UnDelete1(long id)
        {
            TranslatedString curr = Read1(id);
            curr.IsDeleted = false;
            Update1(curr);
        }

        public static void DeleteN( List<long> idList )
        {
            List<tblTranslatedString> tableItemsList = CurrDBContext.Get().tblTranslatedString.Where(x => idList.Contains(x.Id)).ToList();

            foreach (tblTranslatedString currTableItem in tableItemsList)
                currTableItem.IsDeleted = true;

            CurrDBContext.Get().SaveChanges();
        }

        public static void UnDeleteN( List<long> idList )
        {
            List<tblTranslatedString> tableItemsList = CurrDBContext.Get().tblTranslatedString.Where(x => idList.Contains(x.Id)).ToList();

            foreach (tblTranslatedString currTableItem in tableItemsList)
                currTableItem.IsDeleted = true;

            CurrDBContext.Get().SaveChanges();
        }
    }
}
