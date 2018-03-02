namespace Common.DataTransferObjects.AppIdAndAuth.Authorization
{
    using System;

    public class ComplexEntity
    {
        public long RoleId { set; get; }
        public String ComplexEntityName { set; get; }

        public Boolean AllowMethodReadWithFilters { set; get; } = false;
    }
}
