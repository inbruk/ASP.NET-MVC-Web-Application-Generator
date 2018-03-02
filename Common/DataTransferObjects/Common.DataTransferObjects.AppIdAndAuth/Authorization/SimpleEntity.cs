namespace Common.DataTransferObjects.AppIdAndAuth.Authorization
{
    using System;

    public class SimpleEntity
    {
        public long RoleId { set; get; }
        public long EntityId { set; get; }

        public Boolean AllowMethodReadWithFilters { set; get; } = false;
        public Boolean AllowMethodCreateOne { set; get; } = false;
        public Boolean AllowMethodReadOne { set; get; } = false;
        public Boolean AllowMethodUpdateOne { set; get; } = false;
        public Boolean AllowMethodDeleteOne { set; get; } = false;
        public Boolean AllowMethodCreateMultiple { set; get; } = false;
        public Boolean AllowMethodReadMultiple { set; get; } = false;
        public Boolean AllowMethodUpdateMultiple { set; get; } = false;
        public Boolean AllowMethodDeleteMultiple { set; get; } = false;
        public Boolean AllowMethodCreateLink { set; get; } = false;
        public Boolean AllowMethodReadLink { set; get; } = false;
        public Boolean AllowMethodUpdateLink { set; get; } = false;
        public Boolean AllowMethodDeleteLink { set; get; } = false;
    }
}
