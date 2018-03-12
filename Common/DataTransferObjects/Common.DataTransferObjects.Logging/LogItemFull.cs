namespace Common.DataTransferObjects.Logging
{
    using System;

    public class LogItemFull
    {
        public LogItem LogItem { get; }
        public SystemInfo SystemInfo { get; }
        public ExceptionInfo ExceptionInfo { get; }

        public LogItemFull( LogItem logItem, SystemInfo systemInfo, ExceptionInfo exceptionInfo )
        {
            LogItem = logItem;
            SystemInfo = systemInfo;
            ExceptionInfo = exceptionInfo;
        }
    }
}
