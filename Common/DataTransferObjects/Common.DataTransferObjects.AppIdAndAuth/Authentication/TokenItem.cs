namespace Common.DataTransferObjects.AppIdAndAuth.Authentication
{
    using System;
    using Auxiliary.CommonOptions;

    public class TokenItem
    {
        public long Id { get; }
        public DateTime StartDateTime { get; }
        public Guid  ActionToken { get; }
        public long  ActionTokenTime { get { return Constants.ActionTokenTime; } }
        public Guid  RefreshToken { get; }
        public long  RefreshTokenTime { get { return Constants.RefreshTokenTime; } }

        public TokenItem(long id, Guid actToken, Guid refToken)
        {
            Id = id;
            ActionToken = actToken;
            RefreshToken = refToken;
            StartDateTime = DateTime.Now;
        }

        private long GetSeconsToNow(DateTime dt)
        {
            TimeSpan range = DateTime.Now - dt;
            long result = (long)(range.TotalSeconds);
            return result;
        }

        public Boolean IsActionTokenActual()
        {
            long seconds = GetSeconsToNow(StartDateTime);
            if (seconds < ActionTokenTime)
                return true;
            else
                return false;
        }

        public Boolean IsRefreshTokenActual()
        {
            long seconds = GetSeconsToNow(StartDateTime);
            if (seconds < RefreshTokenTime)
                return true;
            else
                return false;
        }
    }
}
