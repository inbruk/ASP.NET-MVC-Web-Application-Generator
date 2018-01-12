namespace AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer
{
    using System.Collections.Generic;

    public static class Configuration
    {
        public static List<WebPage> WebPages { get; } = new List<WebPage>();
        public static void AddPage(WebPage currWebPage)
        {
            WebPages.Add(currWebPage);
        }
    }
}
