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
        private String _name;
        private long _number;

        public EnumItem(String nam, long num)
        {
            _name = nam;
            _number = num;
        }

        public String GetEnumRow()
        {
            String result = "    " + _name.ToString() + "=" + _number.ToString() + ", ";
            return result;
        }
    }
}
