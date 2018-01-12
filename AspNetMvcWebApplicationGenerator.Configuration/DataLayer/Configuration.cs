namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public static class OverallConfiguration
    {
        public static Dictionary<long, LanguageItem>    Languages { get; } = new Dictionary<long, LanguageItem>();
        public static Dictionary<String, Directory>     DirectoryConfigurations { get; } = new Dictionary<String, Directory>();
        public static Dictionary<String, Entity>        EntitiesConfigurations { get; } = new Dictionary<String, Entity>();
        public static Dictionary<String, ComplexEntity> ComplexEntitiesConfigurations { get; } = new Dictionary<string, ComplexEntity>();

        public static void AddLanguage(LanguageItem langContent)
        {
            long id = langContent.Id;
            Languages.Add(id, langContent);
        }

        public static void AddDirectory(Directory directory)
        {
            String enumName = directory.EnumName;
            DirectoryConfigurations.Add(enumName, directory);
        }

        public static void AddEntity(Entity entity)
        {
            String enumName = entity.Name;
            EntitiesConfigurations.Add(enumName, entity);
        }

        public static void AddComplexEntity(ComplexEntity complEntity)
        {
            String Name = complEntity.Name;
            ComplexEntitiesConfigurations.Add(Name, complEntity);
        }
    }
}
