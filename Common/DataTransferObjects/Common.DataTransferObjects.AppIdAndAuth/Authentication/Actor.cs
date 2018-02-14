namespace Common.DataTransferObjects.AppIdAndAuth.Authentication
{
    using System;

    public class Actor
    {
        public long Id { set; get; }
        public String Login { set; get; }
        public String Password { set; get; } = null; // don't saved, it used only in update, when !=null
        public String PasswordSalt { set; get; }
        public String PasswordHash { set; get; }
        public Boolean IsBanned { set; get; } = false;
        public long RoleId { set; get; }
    }
}
