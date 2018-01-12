namespace AspNetMvcWebApplicationGenerator.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;
    using AspNetMvcWebApplicationGenerator.Configuration.BusinessLogicAndWebServicesLayer;
    using AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer;

    public class OverallConfiguration
    {
        public DLConfiguration   dlConfiguration { get; }
        public BLWSConfiguration blwsConfiguration { get; }
        public WUIConfiguration  wuiConfiguration { get; }

        public OverallConfiguration
        (
            DLConfiguration   dlConf,
            BLWSConfiguration blwsConf,
            WUIConfiguration  wuiConf
        )
        {
            dlConfiguration = dlConf;
            blwsConfiguration = blwsConf;
            wuiConfiguration = wuiConf;
        }
    }
}
