namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId
{
    using System;

    public class Method : BaseItem
    {
        public long SubsystemId { get; }
        public Boolean IsSpecial { get; }

        public Boolean IsOrdinary { get { return !IsSpecial; } }

        public Method( long id, String enumName, long subsystemId, Boolean isSpec ) 
            : base(id, enumName)
        {
            SubsystemId = subsystemId;
            IsSpecial = isSpec;
        }
    }
}
