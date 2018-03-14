namespace Common.DataTransferObjects.Logging
{
    using System;

    public class LogItem
    {
        public long Id { get; }
        public DateTimeOffset DateTime { get; }
        public String Value { get; }
        public String Comment { get; }
        public long ApplicationId { get; }
        public long LayerId { get; }
        public long SubsystemId { get; }
        public long MethodId { get; }
        public String MethodName { get; }
        public long? StringNumber { get; }
        public long? SystemInfoId { get; }
        public long? ExceptionInfoId { get; }

        public LogItem
        (
            long id,
            DateTimeOffset dateTime,
            String value,
            String comment,
            long applicationId,
            long layerId,
            long subsystemId,
            long methodId,
            String methodName,
            long? stringNumber,
            long? systemInfoId,
            long? exceptionInfoId
        )
        {
            Id = Id;
            DateTime = dateTime;
            Value = value;
            Comment = comment;
            ApplicationId = applicationId;
            LayerId = layerId;
            SubsystemId = subsystemId;
            MethodId = methodId;
            MethodName = methodName;
            StringNumber = stringNumber;
            SystemInfoId = systemInfoId;
            ExceptionInfoId = exceptionInfoId;
        }
    }
}
