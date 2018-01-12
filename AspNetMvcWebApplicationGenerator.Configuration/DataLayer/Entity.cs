namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class Entity
    {
        public EntityType Type { set; get; }
        public String Name { set; get; }
        public Entity()
        {
            Type = Type;
            Name = Name;
        }

        public Dictionary<String, EntityField> Fields { get; } = new Dictionary<string, EntityField>();
        public void AddField(EntityField field)
        {
            String enumName = field.Name;
            Fields.Add(enumName, field);
        }
    }
}
