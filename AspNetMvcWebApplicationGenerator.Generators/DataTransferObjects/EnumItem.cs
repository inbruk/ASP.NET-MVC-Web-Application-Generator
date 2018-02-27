using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcWebApplicationGenerator.Generators.DataTransferObjects
{
    using System;

    public class EnumItem
    {
        public long   Id { set; get; }
        public String EnumName { set; get; }

        public String GetEnumRow()
        {
            String usefulEName = EnumName.Replace(" ", "");
            usefulEName = usefulEName.Replace(" ", "");

            String result = "        " + usefulEName.ToString() + "=" + Id.ToString() + ", ";
            return result;
        }
    }
}
