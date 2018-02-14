namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId
{
    using System;

    public class Application : BaseItem
    {
        public long ProjectId { get; }

        public Application(long id, String enumName, long projectId) 
            : base(id, enumName)
        {
            ProjectId = projectId;
        }
    }
}
