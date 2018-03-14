namespace Common.BusinessLogicLayer.Logging
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.Logging;
    using Common.DataAccessLayer.Logging;

    public static class LogItemTools
    {
        public static void Create1(LogItem item)
        {
            tblLogItem currItem = new tblLogItem
            {
                DateTime = item.DateTime,
                Value  = item.Value,
                Comment  = item.Comment,
                ApplicationId  = item.ApplicationId,
                LayerId  = item.LayerId,
                SubsystemId  = item.SubsystemId,
                MethodId  = item.MethodId,
                MethodName  = item.MethodName,
                StringNumber  = item.StringNumber,
                SystemInfoId  = item.SystemInfoId,
                ExceptionInfoId  = item.ExceptionInfoId
            };

            CurrDBContext.Get().tblLogItem.Add(currItem);
            CurrDBContext.Get().SaveChanges();
        }

        public static LogItem Read1(long id)
        {
            LogItem result = CurrDBContext.Get().tblLogItem.Where(x => x.Id == id).
                Select
                (
                    x =>
                    new LogItem
                    (
                        x.Id,
                        x.DateTime,
                        x.Value,
                        x.Comment,
                        x.ApplicationId,
                        x.LayerId,
                        x.SubsystemId,
                        x.MethodId,
                        x.MethodName,
                        x.StringNumber,
                        x.SystemInfoId,
                        x.ExceptionInfoId
                    )
                ).SingleOrDefault();

            return result;
        }

        public static List<LogItem> ReadN(List<long> idList)
        {
            if (idList.Count > Constants.MaxListSize)
            {
                throw new Exception("Maximum list size is exceeded in LogItemTools.ReadN(list) !");
            }

            List<LogItem> result = CurrDBContext.Get().tblLogItem.Where(x => idList.Contains(x.Id)).
                Select
                (
                    x =>
                    new LogItem
                    (
                        x.Id,
                        x.DateTime,
                        x.Value,
                        x.Comment,
                        x.ApplicationId,
                        x.LayerId,
                        x.SubsystemId,
                        x.MethodId,
                        x.MethodName,
                        x.StringNumber,
                        x.SystemInfoId,
                        x.ExceptionInfoId
                    )
                ).ToList();

            return result;
        }

        public static void Update1(LogItem item)
        {
            tblLogItem dataItem = CurrDBContext.Get().tblLogItem.Where(x => x.Id == item.Id).Single();

            dataItem.Id = item.Id;
            dataItem.DateTime = item.DateTime;
            dataItem.Value = item.Value;
            dataItem.Comment = item.Comment;
            dataItem.ApplicationId = item.ApplicationId;
            dataItem.LayerId = item.LayerId;
            dataItem.SubsystemId = item.SubsystemId;
            dataItem.MethodId = item.MethodId;
            dataItem.MethodName = item.MethodName;
            dataItem.StringNumber = item.StringNumber;
            dataItem.SystemInfoId = item.SystemInfoId;
            dataItem.ExceptionInfoId = item.ExceptionInfoId;

            CurrDBContext.Get().SaveChanges();
        }

        public static void Delete1(long id)
        {
            tblLogItem item = CurrDBContext.Get().tblLogItem.Where(x => x.Id == id).SingleOrDefault();
            CurrDBContext.Get().tblLogItem.Remove(item);
            CurrDBContext.Get().SaveChanges();
        }


        public static void DeleteN(List<long> idList)
        {
            if (idList.Count > Constants.MaxListSize)
            {
                throw new Exception("Maximum list size is exceeded in LogItemTools.DeleteN(list) !");
            }

            List<tblLogItem> items = CurrDBContext.Get().tblLogItem.Where(x => idList.Contains(x.Id)).ToList();
            CurrDBContext.Get().tblLogItem.RemoveRange(items);
            CurrDBContext.Get().SaveChanges();
        }
    }
}
