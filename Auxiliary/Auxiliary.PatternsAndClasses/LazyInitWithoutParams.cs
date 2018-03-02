namespace Auxiliary.PatternsAndClasses
{
    public class LazyInitWithoutParams<T>
        where T : class, new()
    {
        private static T _value = null;

        public static T Get()
        {
            if (_value == null)
                _value = new T();

            return _value;
        }
    }
}
