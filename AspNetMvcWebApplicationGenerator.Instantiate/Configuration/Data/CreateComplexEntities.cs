namespace AspNetMvcWebApplicationGenerator.Instantiate.Configuration.Data
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    public static class CreateComplexEntities
    {
        public static void Create()
        {
            DataConfiguration.AddComplexEntity
            (
                new ComplexEntity
                (
                    "OrderCustomer",
                    false,
                    "Order",
                    "Ord",
                    new List<ComplexEntityLink>()
                    {
                         new ComplexEntityLink( ComplexEntityLinkType.Inner, "Ord", "Customer", "Customer", "Cust", "Id" )
                    }
                )
            );
            DataConfiguration.AddComplexEntity
            (
                new ComplexEntity
                (
                    "OrderDriver",
                    false,
                    "Order",
                    "Ord",
                    new List<ComplexEntityLink>()
                    {
                         new ComplexEntityLink( ComplexEntityLinkType.M2MInner, "Ord", "Driver", "Driver", "Drv", "Order" )
                    }
                )
            );
        }
    }
}
