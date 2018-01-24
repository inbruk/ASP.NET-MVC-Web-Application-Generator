namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.Data
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
                    "Order",
                    "Ord",
                    new List<ComplexEntityLink>()
                    {
                         new ComplexEntityLink( ComplexEntityLinkType.Left, "Ord", "Driver", "Driver", "Drv", "Order" )
                    }
                )
            );
        }
    }
}
