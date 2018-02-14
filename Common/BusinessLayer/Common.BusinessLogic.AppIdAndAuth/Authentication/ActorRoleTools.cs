namespace Common.BusinessLogic.AppIdAndAuth.Authentication
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Common.DataTransferObjects.AppIdAndAuth.Authentication;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public static class ActorRoleTools
    {
        public const int MaxListSize = 100;

        private static DAL.Common_AppIdAndAuth_Entities _internalDBContext = null;
        private static DAL.Common_AppIdAndAuth_Entities CurrDBContext
        {
            get
            {
                if (_internalDBContext == null)
                {
                    _internalDBContext = new DAL.Common_AppIdAndAuth_Entities();
                }
                return _internalDBContext;
            }
        }

        public static ActorRole Read(long id)
        {
            Actor act = ActorTools.Read(id);
            Role rol = RoleTools.Read(act.RoleId);
            ActorRole result = new ActorRole(act, rol);
            return result;
        }

        public static List<ActorRole> Read(List<long> actorsIdsList)
        {
            if (actorsIdsList.Count > MaxListSize)
            {
                throw new Exception("Maximum list size is exceeded in ActorTools.Read(list) !");
            }

            List<Actor> actorsList = ActorTools.Read(actorsIdsList);
            List<long>  rolesIdsList = actorsList.Select(x => x.RoleId).ToList();
            List<Role>  roles = RoleTools.Read(rolesIdsList);

            List<ActorRole> result = new List<ActorRole>();
            foreach (Actor currActor in actorsList)
            {
                Role currRole = roles.Single( x => x.Id == currActor.RoleId );
                result.Add( new ActorRole(currActor,currRole) );
            }

            return result;
        }

    }
}
