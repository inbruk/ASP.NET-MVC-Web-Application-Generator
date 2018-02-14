namespace Common.WebServiceClient.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.ApplicationId;

    public enum enSubsystem
    {
        Languages = 1,
        Directories = 2,
        TranslatedStrings = 3,

        Project = 4,
        Layer = 5,
        Application = 6,
        Subsystem = 7,
        ProjAppSubTools = 8,

        ActorTools = 9,
        TokenTools = 10,

        Authorization = 11,

        SystemInfo = 12,
        StartShutdownHalt = 13,
        Logging = 14,

        Engine = 15,
        WebApplication = 16,
        DriverMobileApp = 17
    };

    public static class SubsystemTools
    {
        private static Dictionary<enSubsystem, enApplication> links =
            new Dictionary<enSubsystem, enApplication>
            {
                { enSubsystem.Languages, enApplication.DirLangStrings },
                { enSubsystem.Directories, enApplication.DirLangStrings },
                { enSubsystem.TranslatedStrings, enApplication.DirLangStrings },

                { enSubsystem.Project, enApplication.ApplicationId },
                { enSubsystem.Layer, enApplication.ApplicationId },
                { enSubsystem.Application, enApplication.ApplicationId },
                { enSubsystem.Subsystem, enApplication.ApplicationId },
                { enSubsystem.ProjAppSubTools, enApplication.ApplicationId },

                { enSubsystem.ActorTools, enApplication.Authentication },
                { enSubsystem.TokenTools, enApplication.Authentication },
                { enSubsystem.Authorization, enApplication.Authorization },
                
                { enSubsystem.SystemInfo, enApplication.Logging },
                { enSubsystem.StartShutdownHalt, enApplication.Logging },
                { enSubsystem.Logging, enApplication.Logging },

                { enSubsystem.Engine, enApplication.Engine },
                { enSubsystem.WebApplication, enApplication.WebApplication },
                { enSubsystem.DriverMobileApp, enApplication.DriverMobileApp }
            };

        private static Subsystem ConvertEnum(enSubsystem en)
        {
            long applicationId = (long)(links[en]);
            Subsystem result = new Subsystem((long)(en), en.ToString(), applicationId);
            return result;
        }

        private static Dictionary<long, Subsystem> Subsystems { get; }

        static SubsystemTools()
        {
            Subsystems = new Dictionary<long, Subsystem>();
            foreach (enSubsystem currEn in Enum.GetValues(typeof(enSubsystem)))
            {
                Subsystem currItem = ConvertEnum(currEn);
                Subsystems.Add(currItem.Id, currItem);
            }
        }

        public static Subsystem GetOneById(enSubsystem id)
        {
            Subsystem result = Subsystems[(long)id];
            return result;
        }

        public static List<Subsystem> GetAll()
        {
            var list = Subsystems.Values.ToList();
            return list;
        }
    }
}
