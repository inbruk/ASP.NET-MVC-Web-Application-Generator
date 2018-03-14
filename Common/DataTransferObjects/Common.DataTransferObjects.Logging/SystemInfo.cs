namespace Common.DataTransferObjects.Logging
{
    using System;

    public class SystemInfo
    {
        public long   Id { get; }
        public string CommandLine { get; }
        public string CurrentDirectory { get; }
        public string MachineName { get; }
        public string OSVersion { get; }
        public string ProcessorCount { get; }
        public string StackTrace { get; }
        public string SystemDirectory { get; }
        public string SystemPageSize { get; }
        public string UserName { get; }
        public string UserDomainName { get; }
        public bool   Is64BitOperatingSystem { get; }
        public string GetLogicalDrives { get; }

        public SystemInfo
        (
            long id,
            string commandLine,
            string currentDirectory,
            string machineName,
            string oSVersion,
            string processorCount,
            string stackTrace,
            string systemDirectory,
            string systemPageSize,
            string userName,
            string userDomainName,
            bool   is64BitOperatingSystem,
            string getLogicalDrives
        )
        {
            Id = id;
            CommandLine = commandLine;
            CurrentDirectory = currentDirectory;
            MachineName = machineName;
            OSVersion = oSVersion;
            ProcessorCount = processorCount;
            StackTrace = stackTrace;
            SystemDirectory = systemDirectory;
            SystemPageSize = systemPageSize;
            UserName = userName;
            UserDomainName = userDomainName;
            Is64BitOperatingSystem = is64BitOperatingSystem;
            GetLogicalDrives = getLogicalDrives;
        }
    }
}                                                                       
