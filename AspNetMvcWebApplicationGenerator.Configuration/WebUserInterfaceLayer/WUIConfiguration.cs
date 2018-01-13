namespace AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer
{
    using System.Collections.Generic;

    public static class WUIConfiguration
    {
        public static List<WebPage> WebPages { get; } = new List<WebPage>();
        public static void AddWebPage(WebPage webPage)
        {
            WebPages.Add(webPage);
        }
    }
}
