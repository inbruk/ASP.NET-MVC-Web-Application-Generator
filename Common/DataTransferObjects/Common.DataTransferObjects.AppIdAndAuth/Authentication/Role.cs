namespace Common.DataTransferObjects.AppIdAndAuth.Authentication
{
    using System;

    public class Role
    {
        public long Id { set; get; }
        public String EnumName { set; get; }
        public Boolean IsReadOnly { set; get; } = false;
        public Boolean IsDeleted { set; get; } = false;
    }
}
