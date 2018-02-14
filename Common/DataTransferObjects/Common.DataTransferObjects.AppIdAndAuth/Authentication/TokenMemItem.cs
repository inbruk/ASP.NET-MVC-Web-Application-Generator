namespace Common.DataTransferObjects.AppIdAndAuth.Authentication
{
    using System;

    public class TokenInMemItem
    {
        public long Id { get; }
        public Guid Token { get; }

        public TokenInMemItem(long id, Guid token)
        {
            Id = id;
            Token = token;
        }
    }
}
