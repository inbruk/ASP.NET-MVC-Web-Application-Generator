namespace AspNetMvcWebApplicationGenerator.Instantiate.Configuration.Data
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    public class CreateEntities
    {
        public static void Create()
        {
            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.VirtualPartOfObject,
                    "Contact",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong, "Id" ),
                        new EntityField( EntityFieldType.String, "ActualAddress", 3, 24, null, true, LinkType.NoLink, "", 250, false, true, false),
                        new EntityField( EntityFieldType.String, "FormalAddress", 3, 24, null, true, LinkType.NoLink, "", 100, false, true, false),

                        new EntityField( EntityFieldType.String, "PersonalMobilePhone", 8, 11,
                            @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$", 
                            true, LinkType.NoLink, "", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "WorkMobilePhone", 8, 11,
                            @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$",
                            true, LinkType.NoLink, "", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "HomePhone", 8, 11,
                            @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$",
                            true, LinkType.NoLink, "", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "WorkPhone", 5, 24,
                            @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$",
                            true, LinkType.NoLink, "", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "PersonalEMail", 5, 24,
                            @"^(('[\w-\s]+')|([\w-]+(?:\.[\w-]+)*)|('[\w-\s]+')([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)",
                            true, LinkType.NoLink, "", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "WorkEMail", 5, 24,
                            @"^(('[\w-\s]+')|([\w-]+(?:\.[\w-]+)*)|('[\w-\s]+')([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)",
                            true, LinkType.NoLink, "", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "Messenger1", 5, 16, null, true, LinkType.NoLink, "", 100, true, true, false),
                        new EntityField( EntityFieldType.String, "Messenger2", 5, 16, null, true, LinkType.NoLink, "", 100, true, true, false),
                        new EntityField( EntityFieldType.String, "Messenger3", 5, 16, null, true, LinkType.NoLink, "", 100, true, true, false)
                    }
                ),

                new Entity
                (
                    EntityType.VirtualPartOfObject,
                    "Person",
                    new List<EntityField>()
                    {
                        ...
                    }

            );
        }
    }
}
