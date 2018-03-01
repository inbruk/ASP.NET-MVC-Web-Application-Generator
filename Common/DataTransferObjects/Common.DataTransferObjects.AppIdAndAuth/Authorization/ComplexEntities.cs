namespace Common.DataTransferObjects.AppIdAndAuth.Authorization
{
    using System;

    public class ComplexEntities
    {
        public long RoleId { set; get; }
        public String ComplexEntityName { set; get; }

        public Boolean AllowMethodReadWithFilters { set; get; } = false;
    }
}
