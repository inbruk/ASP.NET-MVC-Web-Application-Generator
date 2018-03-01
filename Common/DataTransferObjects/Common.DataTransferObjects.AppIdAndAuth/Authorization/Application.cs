namespace Common.DataTransferObjects.AppIdAndAuth.Authorization
{
    using System;

    public class Application
    {
        public long RoleId { set; get; }
        public long ApplicationId { set; get; }

        public Boolean AllowLogIn { set; get; } = false;
    }
}
