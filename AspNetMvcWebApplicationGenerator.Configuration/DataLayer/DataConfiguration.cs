namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public static class DataConfiguration
    {
        public static String OutputPath { set; get; }

        public static Dictionary<long, Project>     Projects { get; } = new Dictionary<long, Project>();
        public static Dictionary<long, Application> Applications { get; } = new Dictionary<long, Application>();
        public static Dictionary<long, Subsystem>   Subsystems { get; } = new Dictionary<long, Subsystem>();
        public static Dictionary<long, Layer>       Layers { get; } = new Dictionary<long, Layer>();


        public static Dictionary<long,   LanguageItem>  Languages { get; } = new Dictionary<long, LanguageItem>();
        public static Dictionary<String, Directory>     DirectoryConfigurations { get; } = new Dictionary<String, Directory>();
        public static Dictionary<String, Entity>        EntitiesConfigurations { get; } = new Dictionary<String, Entity>();
        public static Dictionary<String, ComplexEntity> ComplexEntitiesConfigurations { get; } = new Dictionary<string, ComplexEntity>();

        public static void AddProject(Project item)
        {
            Projects.Add(item.Id, item);
        }

        public static void AddApplication(Application item)
        {
            Applications.Add(item.Id, item);
        }

        public static void AddSubsystem(Subsystem item)
        {
            Subsystems.Add(item.Id, item);
        }

        public static void AddLayer(Layer item)
        {
            Layers.Add(item.Id, item);
        }

        public static void AddLanguage(LanguageItem lang)
        {
            Languages.Add(lang.Id, lang);
        }

        public static void AddDirectory(Directory dir)
        {
            DirectoryConfigurations.Add(dir.EnumName, dir);
        }

        public static void AddEntity(Entity ent)
        {
            EntitiesConfigurations.Add(ent.Name, ent);
        }

        public static void AddComplexEntity(ComplexEntity cEnt)
        {
            ComplexEntitiesConfigurations.Add(cEnt.Name, cEnt);
        }
    }
}
