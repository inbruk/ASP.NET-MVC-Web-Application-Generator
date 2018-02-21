namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId
{
    using System;

    public abstract class BaseItem
    {
        public long Id { get; }
        public String EnumName { get; }

        public BaseItem() { ; }
        public BaseItem
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
