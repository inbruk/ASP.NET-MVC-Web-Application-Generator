namespace AspNetMvcWebApplicationGenerator.Generators.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public static class DataConfiguration
    {
        public static String OutputPath { set; get; }

        public static Dictionary<long,   LanguageItem>  Languages { get; } = new Dictionary<long, LanguageItem>();
        public static Dictionary<String, Directory>     DirectoryConfigurations { get; } = new Dictionary<String, Directory>();
        public static Dictionary<String, Entity>        EntitiesConfigurations { get; } = new Dictionary<String, Entity>();
        public static Dictionary<String, ComplexEntity> ComplexEntitiesConfigurations { get; } = new Dictionary<string, ComplexEntity>();

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
