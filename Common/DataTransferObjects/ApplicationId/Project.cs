namespace Common.DataTransferObjects.ApplicationId
{
    using System;
    using En = Common.DataTransferObjects.ApplicationId.Enums;

    public class Project
    {
        public En.Project Id { get; }
        public String EnumName { get; }

        public Project
        (
            En.Project id
        )
        {
            Id = id;
            EnumName = Enum.GetName( typeof(En.Project), id );
        }
    }
}
