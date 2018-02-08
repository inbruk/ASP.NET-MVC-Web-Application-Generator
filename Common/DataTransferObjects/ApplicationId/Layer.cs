namespace Common.DataTransferObjects.ApplicationId
{
    using System;

    public class Layer
    {
        public long Id { get; }
        public String EnumName { get; }

        public Layer
        (
            long id,
            String enumName
        )
        {
            Id = id;
            EnumName = enumName;
        }
    }
}
