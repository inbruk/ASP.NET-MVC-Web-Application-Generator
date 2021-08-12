namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.Data
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Generators.Configuration.DataLayer;

    internal static class CreateComplexEntities
    {
        public static void Create()
        {
            DataConfiguration.AddComplexEntity
            (
                new ComplexEntity
                (
                    "OrderCustomer",
                     false,
                    "tblOrder",
                    "Ord",
                    new List<ComplexEntityLink>()
                    {
                         new ComplexEntityLink( ComplexEntityLinkType.Inner, "Ord", "Customer", false, "tblCustomer", "Cust", "Id" )
                    }
                )
            );
            DataConfiguration.AddComplexEntity
            (
                new ComplexEntity
                (
                    "OrderDriver",
                    true,
                    "n2mOrderDriver",
                    "OrdDrv",
                    new List<ComplexEntityLink>()
                    {
                         new ComplexEntityLink( ComplexEntityLinkType.Left, "OrdDrv", "Order",  false, "tblOrder",  "Ord", "Id" ),
                         new ComplexEntityLink( ComplexEntityLinkType.Left, "OrdDrv", "Driver", false, "tblDriver", "Drv", "Id" )
                    }
                )
            );
        }
    }
}
