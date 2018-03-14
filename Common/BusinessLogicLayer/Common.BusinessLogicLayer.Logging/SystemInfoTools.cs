namespace Common.BusinessLogicLayer.Logging
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.Logging;
    using Common.DataAccessLayer.Logging;

    public static class SystemInfoTools
    {
        public static void Create1(SystemInfo item)
        {
            tblSystemInfo currItem = new tblSystemInfo
            {
                CommandLine = item.CommandLine,
                CurrentDirectory = item.CurrentDirectory,
                MachineName = item.MachineName,
                OSVersion = item.OSVersion,
                ProcessorCount = item.ProcessorCount,
                StackTrace = item.StackTrace,
                SystemDirectory = item.SystemDirectory,
                SystemPageSize = item.SystemPageSize,
                UserName = item.UserName,
                UserDomainName = item.UserDomainName,
                Is64BitOperatingSystem = item.Is64BitOperatingSystem,
                GetLogicalDrives = item.GetLogicalDrives,
            };

            CurrDBContext.Get().tblSystemInfo.Add(currItem);
            CurrDBContext.Get().SaveChanges();
        }

        public static SystemInfo Read1(long id)
        {
            SystemInfo result = CurrDBContext.Get().tblSystemInfo.Where(x => x.Id == id).
                Select
                (
                    x => 
                    new SystemInfo
                    (
                        x.Id,
                        x.CommandLine,
                        x.CurrentDirectory,
                        x.MachineName,
                        x.OSVersion,
                        x.ProcessorCount,
                        x.StackTrace,
                        x.SystemDirectory,
                        x.SystemPageSize,
                        x.UserName,
                        x.UserDomainName,
                        x.Is64BitOperatingSystem,
                        x.GetLogicalDrives
                    )
                ).SingleOrDefault();

            return result;
        }

        public static List<SystemInfo> ReadN(List<long> idList)
        {
            if (idList.Count > Constants.MaxListSize)
            {
                throw new Exception("Maximum list size is exceeded in SystemInfoTools.ReadN(list) !");
            }

            List<SystemInfo> result = CurrDBContext.Get().tblSystemInfo.Where(x => idList.Contains(x.Id)).
                Select
                (
                    x => 
                    new SystemInfo
                    (
                        x.Id,
                        x.CommandLine,
                        x.CurrentDirectory,
                        x.MachineName,
                        x.OSVersion,
                        x.ProcessorCount,
                        x.StackTrace,
                        x.SystemDirectory,
                        x.SystemPageSize,
                        x.UserName,
                        x.UserDomainName,
                        x.Is64BitOperatingSystem,
                        x.GetLogicalDrives
                    )
                ).ToList();

            return result;
        }

        public static void Update1(SystemInfo item)
        {
            tblSystemInfo dataItem = CurrDBContext.Get().tblSystemInfo.Where(x => x.Id == item.Id).Single();

            dataItem.Id = item.Id;
            dataItem.CommandLine = item.CommandLine;
            dataItem.CurrentDirectory = item.CurrentDirectory;
            dataItem.MachineName = item.MachineName;
            dataItem.OSVersion = item.OSVersion;
            dataItem.ProcessorCount = item.ProcessorCount;
            dataItem.StackTrace = item.StackTrace;
            dataItem.SystemDirectory = item.SystemDirectory;
            dataItem.SystemPageSize = item.SystemPageSize;
            dataItem.UserName = item.UserName;
            dataItem.UserDomainName = item.UserDomainName;
            dataItem.Is64BitOperatingSystem = item.Is64BitOperatingSystem;
            dataItem.GetLogicalDrives = item.GetLogicalDrives;

            CurrDBContext.Get().SaveChanges();
        }

        public static void Delete1(long id)
        {
            tblSystemInfo item = CurrDBContext.Get().tblSystemInfo.Where(x => x.Id == id).SingleOrDefault();
            CurrDBContext.Get().tblSystemInfo.Remove(item);
            CurrDBContext.Get().SaveChanges();
        }


        public static void DeleteN(List<long> idList)
        {
            if (idList.Count > Constants.MaxListSize)
            {
                throw new Exception("Maximum list size is exceeded in SystemInfoTools.DeleteN(list) !");
            }

            List<tblSystemInfo> items = CurrDBContext.Get().tblSystemInfo.Where(x => idList.Contains(x.Id) ).ToList();
            CurrDBContext.Get().tblSystemInfo.RemoveRange(items);
            CurrDBContext.Get().SaveChanges();
        }
    }
}
