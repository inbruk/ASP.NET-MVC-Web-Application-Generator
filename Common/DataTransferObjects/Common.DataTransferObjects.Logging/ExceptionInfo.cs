namespace Common.DataTransferObjects.Logging
{
    using System;
 
    public class ExceptionInfo
    {
        public long  Id { get; }
        public long? InnerExceptionId { get; }
        public bool IsParentException { get; }
        public DateTime DateTime { get; }
        public string Levels { get; }
        public string Value { get; }
        public string Data { get; }
        public string TargetSite { get; }
        public string Message { get; }
        public string StackTrace { get; }
        public string Sources { get; }

        public ExceptionInfo
        (
            long id,
            long? innerExceptionId,
            bool  isParentException, 
            DateTime dateTime,
            string levels, 
            string value, 
            string data, 
            string targetSite, 
            string message,
            string stackTrace, 
            string sources 
        )
        {
            Id = id;
            InnerExceptionId = innerExceptionId;
            IsParentException = isParentException;
            DateTime = dateTime;
            Levels = levels;
            Value = value;
            Data = data;
            TargetSite = targetSite;
            Message = message;
            StackTrace = stackTrace;
            Sources = sources;
        }
    }
}
