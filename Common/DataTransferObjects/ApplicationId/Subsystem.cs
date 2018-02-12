﻿namespace Common.DataTransferObjects.ApplicationId
{
    using System;

    public class Subsystem : BaseItem
    {
        public long ApplicationId { get; }

        public Subsystem(long id, String enumName, long applicationId)
            : base(id, enumName)
        {
            ApplicationId = applicationId;
        }
    }
}