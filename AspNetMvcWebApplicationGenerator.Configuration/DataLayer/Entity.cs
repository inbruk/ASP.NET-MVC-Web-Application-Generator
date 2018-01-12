namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class Entity
    {
        public EntityType Type { set; get; }
        public String Name { set; get; }

        public Dictionary<String, EntityField> Fields { get; } = new Dictionary<string, EntityField>();

        public Entity(EntityType type, String name, List<EntityField> fields)
        {
            Type = type;
            Name = name;

            foreach (var currField in fields)
                Fields.Add(currField.Name, currField);
        }
    }
}
