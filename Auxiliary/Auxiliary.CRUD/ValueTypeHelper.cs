using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliary.CRUD
{
    // ATTENTION !!! WORK FOR ALL BESIDES DictionaryItem !!!
    public static class ValueTypeHelper
    {
        public static enFilterItemValueTypes Get(Object currObj)
        {
            enFilterItemValueTypes result;
            TypeCode currTypeCode = Type.GetTypeCode(currObj.GetType());
            switch (currTypeCode)
            {
                case TypeCode.String: result = enFilterItemValueTypes.String; break;
                case TypeCode.Int32: result = enFilterItemValueTypes.SInt; break;
                case TypeCode.UInt32: result = enFilterItemValueTypes.UInt; break;
                case TypeCode.Int64: result = enFilterItemValueTypes.SLong; break;
                case TypeCode.UInt64: result = enFilterItemValueTypes.ULong; break;
                case TypeCode.Single: result = enFilterItemValueTypes.Float; break;
                case TypeCode.DateTime: result = enFilterItemValueTypes.DateTimeOffset; break;
                case TypeCode.Boolean: result = enFilterItemValueTypes.Boolean; break;
                case TypeCode.Decimal: result = enFilterItemValueTypes.Decimal; break;
                default: throw new Exception("Error: it can't get unsupported ");
            }

            return result;
        }
    }
}
