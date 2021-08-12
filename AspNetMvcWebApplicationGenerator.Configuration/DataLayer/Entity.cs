namespace AspNetMvcWebApplicationGenerator.GeneratorsConfiguration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class Entity
    {
        public EntityType Type { get; }
        public String Name { get; }
        public Boolean IsActorCreateAndChagedDateRequired { get; } // пока не поддерживается
        public Boolean IsHistoryRequired { get; } // пока не поддерживается

        public Dictionary<String, EntityField> Fields { get; } = new Dictionary<string, EntityField>();

        public Entity( EntityType type, String name, List<EntityField> fields, Boolean isActorRequired = false, Boolean isHistoryRequired = false )
        {
            Type = type;
            Name = name;

            foreach (var currField in fields)
                Fields.Add(currField.Name, currField);

            IsActorCreateAndChagedDateRequired = isActorRequired;
            IsHistoryRequired = isHistoryRequired;
        }
    }
}
