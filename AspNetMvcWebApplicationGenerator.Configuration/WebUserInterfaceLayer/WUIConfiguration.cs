namespace AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer
{
    using System.Collections.Generic;

    public class WUIConfiguration
    {
        public List<WebPage> WebPages { get; } 

        public WUIConfiguration( List<WebPage> webPages )
        {
            WebPages = webPages;
        }
    }
}
