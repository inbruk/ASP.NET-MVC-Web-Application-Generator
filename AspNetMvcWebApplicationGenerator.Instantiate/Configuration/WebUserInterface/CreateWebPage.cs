namespace AspNetMvcWebApplicationGenerator.Instantiate.Configuration.WebUserInterface
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer;

    public static class CreateWebPage
    {
        public static void Create()
        {
            WUIConfiguration.AddWebPage(new WebPage(WebPageType.GridWithFiltersAndSorting, "Customer"));
            WUIConfiguration.AddWebPage(new WebPage(WebPageType.Crud1EditFrom, "Customer", false, "Id"));

            WUIConfiguration.AddWebPage(new WebPage(WebPageType.GridWithFiltersAndSorting, "Driver"));
            WUIConfiguration.AddWebPage(new WebPage(WebPageType.Crud1EditFrom, "Driver", false, "Id"));

            WUIConfiguration.AddWebPage(new WebPage(WebPageType.GridWithFiltersAndSorting, "Vehicle"));
            WUIConfiguration.AddWebPage(new WebPage(WebPageType.Crud1EditFrom, "Vehicle", false, "Id"));

            WUIConfiguration.AddWebPage(new WebPage(WebPageType.GridWithFiltersAndSorting, "Order"));
            WUIConfiguration.AddWebPage(new WebPage(WebPageType.Crud1EditFrom, "Order", false, "Id"));

            WUIConfiguration.AddWebPage(new WebPage(WebPageType.Crud1EditFrom, "Account", true, "Id"));

            WUIConfiguration.AddWebPage(new WebPage(WebPageType.AttachDetach1toN, "Vehicle", false, "DriverOwner", "Driver", "Id", null));
            WUIConfiguration.AddWebPage(new WebPage(WebPageType.AttachDetachMtoN, "Order"));

            WUIConfiguration.AddWebPage(new WebPage(WebPageType.GridWithFiltersAndSorting, "OrderCustomer"));
            WUIConfiguration.AddWebPage(new WebPage(WebPageType.GridWithFiltersAndSorting, "OrderDriver"));
        }
    }
}
