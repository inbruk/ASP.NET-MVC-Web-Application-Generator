namespace AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OverallConfiguration
    {
        public static Dictionary<String, WebPage> WebPages { get; } = new Dictionary<String, WebPage>();
    }
}
