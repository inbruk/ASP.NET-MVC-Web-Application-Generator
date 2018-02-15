using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliary.PatternsAndClasses
{
    public class LazyInitWithoutParams<T>
        where T : class, new()
    {
        private T _value = null;

        public T Get()
        {
            if (_value == null)
                _value = new T();

            return _value;
        }
    }
}
