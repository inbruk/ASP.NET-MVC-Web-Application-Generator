namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.Data
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    public static class CreateEntities
    {
        public static void Create()
        {
            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.VirtualPartOfObject,
                    "Contacts",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong, "Id" ),
                        new EntityField( EntityFieldType.String, "ActualAddress", 0, 32, null, true, null, LinkType.NoLink, "Contacts", "ActualAddress", 250, false, true, false),
                        new EntityField( EntityFieldType.String, "FormalAddress", 0, 32, null, true, null, LinkType.NoLink, "Contacts", "FormalAddress", 100, false, false, true),

                        new EntityField( EntityFieldType.String, "PersonalMobilePhone", 8, 11,
                            @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$",
                            true, null, LinkType.NoLink, "Contacts", "PersonalMobilePhone", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "WorkMobilePhone", 8, 11,
                            @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$",
                            true, null, LinkType.NoLink, "Contacts", "WorkMobilePhone", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "HomePhone", 8, 11,
                            @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$",
                            true, null, LinkType.NoLink, "Contacts", "HomePhone", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "WorkPhone", 5, 24,
                            @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$",
                            true, null, LinkType.NoLink, "Contacts", "WorkPhone", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "PersonalEMail", 5, 24,
                            @"^(('[\w-\s]+')|([\w-]+(?:\.[\w-]+)*)|('[\w-\s]+')([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)",
                            true, null, LinkType.NoLink, "Contacts", "PersonalEMail", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "WorkEMail", 5, 24,
                            @"^(('[\w-\s]+')|([\w-]+(?:\.[\w-]+)*)|('[\w-\s]+')([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)",
                            true, null, LinkType.NoLink, "Contacts", "WorkEMail", 100, true, true, false),

                        new EntityField( EntityFieldType.String, "Messenger1", 5, 16, null, true, null, LinkType.NoLink, "Contacts", "Messenger1", 100, true, true, false),
                        new EntityField( EntityFieldType.String, "Messenger2", 5, 16, null, true, null, LinkType.NoLink, "Contacts", "Messenger2", 100, true, true, false),
                        new EntityField( EntityFieldType.String, "Messenger3", 5, 16, null, true, null, LinkType.NoLink, "Contacts", "Messenger3", 100, true, true, false)
                    }
                )
            );

            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.VirtualPartOfObject,
                    "PassportInfo",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong,    "Id" ),
                        new EntityField( EntityFieldType.String,   "Comment", 0, 0 ),
                        new EntityField( EntityFieldType.String,   "Series", 0, 8 ),
                        new EntityField( EntityFieldType.String,   "Number", 0, 16 ),
                        new EntityField( EntityFieldType.DateTime, "IssueDate" ),
                        new EntityField( EntityFieldType.String,   "WhoIsIssuer", 0, 512 ),
                        new EntityField( EntityFieldType.String,   "AddressOfResidence", 0, 32 ),
                        new EntityField( EntityFieldType.String,   "AddressOfRegistration", 0, 32 ),
                        new EntityField( EntityFieldType.DateTime, "LastChangeDate" )
                    }
                )
            );


            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.VirtualPartOfObject,
                    "Person",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong,  "Id" ),
                        new EntityField( EntityFieldType.String, "Comment", 0, 0 ),
                        new EntityField( EntityFieldType.String, "FirstName", 0, 16, null, false, null, LinkType.NoLink, "Person", "FirstName", 100, true, true, false  ),
                        new EntityField( EntityFieldType.String, "Surname", 0, 16, null, false, null, LinkType.NoLink, "Person", "Surname", 100, true, true, false ),
                        new EntityField( EntityFieldType.String, "PatronymicName", 0, 16, null, false, null, LinkType.NoLink, "Person", "PatronymicName", 100, true, true, false ),
                        new EntityField( EntityFieldType.DirectoryItem, "Gender", 0, 0, null, false, "Gender" ),
                        new EntityField( EntityFieldType.DirectoryItem, "MaritalStatus", 0, 0, null, false, "MaritalStatus" ),
                        new EntityField( EntityFieldType.DateTime, "BirthDate", 0, 0, null, false, null, LinkType.NoLink, "Person", "BirthDate", 100, true, true, false  ),
                        new EntityField( EntityFieldType.SLong,    "AmountOfChildren" ),
                        new EntityField( EntityFieldType.String, "AddressOfCurrLivingPlace", 0, 32 ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "Contacts", 
                            null, 0, null, false, null, LinkType.One2OneVirtualPartOfObject, "Contacts" ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "PassportInfo",
                            null, 0, null, false, null, LinkType.One2OneVirtualPartOfObject, "PassportInfo" )
                    }
                )
            );

            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.TableRootOrPartOfObject,
                    "Employee",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong,  "Id" ),
                        new EntityField( EntityFieldType.String, "Comment", 0, 0 ),

                        new EntityField( EntityFieldType.DirectoryItem, "Position", 0, 0, null, false, "Position" ),
                        
                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "Person",
                            null, 0, null, false, null, LinkType.One2OneVirtualPartOfObject, "Person" )
                    }
                )
            );

            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.TableRootOrPartOfObject,
                    "Account",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong,  "Id" ),
                        new EntityField( EntityFieldType.String, "Comment", 0, 0 ),
                        new EntityField( EntityFieldType.SLong,  "Balance", null, 0, null, false, null, 
                            LinkType.NoLink, "Account", "Balance", 100, true, true, true ),

                        new EntityField( EntityFieldType.DirectoryItem, "AccountState", 0, 0, null, false, "AccountState",
                            LinkType.NoLink, "Account", "AccountState" )
                    }
                )
            );

            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.TableRootOrPartOfObject,
                    "Customer",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong,  "Id" ),
                        new EntityField( EntityFieldType.String, "Comment", 0, 0 ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "Person",
                            null, 0, null, false, null, LinkType.One2OneVirtualPartOfObject, "Person" ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "PaymentAccount",
                            null, 0, null, false, null, LinkType.One2OneVirtualPartOfObject, "Account" )
                    }
                )
            );

            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.TableRootOrPartOfObject,
                    "Driver",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong,  "Id" ),
                        new EntityField( EntityFieldType.String, "Comment", 0, 0 ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "BalanceAccount",
                            null, 0, null, false, null, LinkType.One2OneVirtualPartOfObject, "Account" ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "Employee",
                            null, 0, null, false, null, LinkType.One2OneVirtualPartOfObject, "Employee" ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "CurrentVehicle",
                            null, 0, null, false, null, LinkType.One2OneTablePartOfObject, "Vehicle" )
                    }
                )
            );

            DataConfiguration.AddEntity
            (
                new Entity
                (
                    EntityType.TableRootOrPartOfObject,
                    "Vehicle",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong,  "Id" ),
                        new EntityField( EntityFieldType.String, "Comment", 0, 0 ),
                        new EntityField( EntityFieldType.DirectoryItem, "Brand", 0, 0, null, false, "VehicleBrand" ),
                        new EntityField( EntityFieldType.String, "Model", 0, 16 ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "DriverOwner",
                            null, 0, null, false, null, LinkType.N2OneTableOtherObject, "Driver" )                        
                    }
                )
            );

            DataConfiguration.AddEntity // чисто тестовый вариант
            (
                new Entity
                (
                    EntityType.TableRootOrPartOfObject,
                    "Order",
                    new List<EntityField>()
                    {
                        new EntityField( EntityFieldType.SLong,  "Id" ),
                        new EntityField( EntityFieldType.String, "Comment", 0, 0 ),

                        new EntityField( EntityFieldType.DateTime, "StartDateTime" ),
                        new EntityField( EntityFieldType.DateTime, "ControlDateTime", 
                            null, 0, null, false, null, LinkType.NoLink, "Order", "ControlDateTime", 100, true, true, false ),

                        new EntityField( EntityFieldType.DateTime, "CloseDateTime" ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "Customer",
                            null, 0, null, false, null, LinkType.One2OneTablePartOfObject, "Customer" ),

                        new EntityField( EntityFieldType.Link2TableOrVirtaulPart, "Driver",
                            null, 0, null, false, null, LinkType.N2MTableOtherObject, "Driver" )
                    }
                )
            );

        }
    }
}
