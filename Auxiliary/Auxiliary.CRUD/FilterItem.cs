using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliary.CRUD
{
    public class FilterItem<T> : IFilterItem
        where T : class, new()
    {
        public String FieldName { get; }
        public enFilterItemTypes ItemType { get; }
        public enFilterItemValueTypes ValueType { get; }
        public enFilterItemCondition ItemCondition { get; }

        public T SingleValue { get; }
        public T StartRangeValue { get; }
        public T EndRangeValue { get; }
        public List<T> ListOfValues { get; }

        private enFilterItemValueTypes GetCurrentValueType()
        {
            Object currObj = null;

            switch( ItemType )
            {
                case enFilterItemTypes.SingleValue:
                    currObj = SingleValue;
                    break;
                case enFilterItemTypes.RangeOfValues:
                    currObj = StartRangeValue;
                    break;
                case enFilterItemTypes.ListOfValues:
                    if (ListOfValues.Count >= 1)
                        currObj = ListOfValues[0];
                    else
                        currObj = SingleValue;
                    break;
                default:
                    throw new Exception("Maximum list size is exceeded in LogItemTools.ReadWithFilter() !");                   
            }

            enFilterItemValueTypes result = ValueTypeHelper.Get(currObj);
            return result;
        }

        public FilterItem(String fieldName, T singleValue)
        {
            FieldName = fieldName;
            SingleValue = singleValue;
            ItemType = enFilterItemTypes.SingleValue;
            ValueType = GetCurrentValueType();
        }

        public FilterItem(String fieldName, T startSingleValue, T endSingleValue)
        {
            FieldName = fieldName;
            StartRangeValue = startSingleValue;
            EndRangeValue = endSingleValue;
            ItemType = enFilterItemTypes.RangeOfValues;
            ValueType = GetCurrentValueType();
        }

        public FilterItem(String fieldName, List<T> list)
        {
            FieldName = fieldName;
            ListOfValues = list;
            ItemType = enFilterItemTypes.ListOfValues;
            ValueType = GetCurrentValueType();
        }

    }
}
