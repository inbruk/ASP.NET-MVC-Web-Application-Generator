namespace Common.DataTransferObjects.AppIdAndAuth.Authentication
{
    using System;

    public class ActorRole 
    {
        Actor Actor { get; }
        Role  Role { get; }

        public ActorRole(Actor act, Role rol)
        {
            Actor = act;
            Role = rol;
        }
    }
}
