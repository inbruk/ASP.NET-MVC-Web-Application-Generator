namespace Common.BusinessLogicLayer.Logging
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.Logging;
    using Common.DataAccessLayer.Logging;

    public static class ExceptionInfoTools
    {
        public static void Create1(ExceptionInfo item)
        {
            tblExceptionInfo currItem = new tblExceptionInfo
            {
                Id = item.Id,
                InnerExceptionId = item.InnerExceptionId,
                DateTime = item.DateTime,
                Levels = item.Levels,
                Value = item.Value,
                Data = item.Data,
                TargetSite = item.TargetSite,
                Message = item.Message,
                StackTrace = item.StackTrace,
                Sources = item.Sources,
            };

            CurrDBContext.Get().tblExceptionInfo.Add(currItem);
            CurrDBContext.Get().SaveChanges();
        }

        public static ExceptionInfo Read1(long id)
        {
            ExceptionInfo result = CurrDBContext.Get().tblExceptionInfo.Where(x => x.Id == id).
                Select
                (
                    x =>
                    new ExceptionInfo
                    (
                        x.Id,
                        x.InnerExceptionId,
                        x.DateTime,
                        x.Levels,
                        x.Value,
                        x.Data,
                        x.TargetSite,
                        x.Message,
                        x.StackTrace,
                        x.Sources
                    )
                ).SingleOrDefault();

            return result;
        }

        public static List<ExceptionInfo> ReadN(List<long> idList)
        {
            if (idList.Count > Constants.MaxListSize)
            {
                throw new Exception("Maximum list size is exceeded in ExceptionInfoTools.ReadN(list) !");
            }

            List<ExceptionInfo> result = CurrDBContext.Get().tblExceptionInfo.Where(x => idList.Contains(x.Id)).
                Select
                (
                    x =>
                    new ExceptionInfo
                    (
                        x.Id,
                        x.InnerExceptionId,
                        x.DateTime,
                        x.Levels,
                        x.Value,
                        x.Data,
                        x.TargetSite,
                        x.Message,
                        x.StackTrace,
                        x.Sources
                    )
                ).ToList();

            return result;
        }

        public static void Update1(ExceptionInfo item)
        {
            tblExceptionInfo dataItem = CurrDBContext.Get().tblExceptionInfo.Where(x => x.Id == item.Id).Single();

            dataItem.Id = item.Id;
            dataItem.InnerExceptionId = item.InnerExceptionId;
            dataItem.DateTime = item.DateTime;
            dataItem.Levels = item.Levels;
            dataItem.Value = item.Value;
            dataItem.Data = item.Data;
            dataItem.TargetSite = item.TargetSite;
            dataItem.Message = item.Message;
            dataItem.StackTrace = item.StackTrace;
            dataItem.Sources = item.Sources;

            CurrDBContext.Get().SaveChanges();
        }

        public static void Delete1(long id)
        {
            tblExceptionInfo item = CurrDBContext.Get().tblExceptionInfo.Where(x => x.Id == id).SingleOrDefault();
            CurrDBContext.Get().tblExceptionInfo.Remove(item);
            CurrDBContext.Get().SaveChanges();
        }


        public static void DeleteN(List<long> idList)
        {
            if (idList.Count > Constants.MaxListSize)
            {
                throw new Exception("Maximum list size is exceeded in ExceptionInfoTools.DeleteN(list) !");
            }

            List<tblExceptionInfo> items = CurrDBContext.Get().tblExceptionInfo.Where(x => idList.Contains(x.Id)).ToList();
            CurrDBContext.Get().tblExceptionInfo.RemoveRange(items);
            CurrDBContext.Get().SaveChanges();
        }
    }
}
