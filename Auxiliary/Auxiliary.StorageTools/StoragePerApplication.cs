namespace Auxiliary.StorageTools
{
    using System;
    using System.Web;

    public static class StoragePerApplication
    {
        private static HttpApplicationState _internalStorage = null;

        static StoragePerApplication()
        {
            HttpContext currContext = HttpContext.Current;
            if (currContext == null)
                _internalStorage = null;
            else
                _internalStorage = currContext.Application;
        }
            
        public static Object Get(String index)
        {
            Object result = _internalStorage==null ? null : (Object)_internalStorage[index];
            return result;
        }

        public static void Put(String index, Object value)
        {
            if( _internalStorage!=null )
                _internalStorage[index] = value;
        }

        public static void Remove(String index)
        {
            if (_internalStorage != null)
                _internalStorage.Remove(index);
        }

        public static void ClearAll()
        {
            if (_internalStorage != null)
                _internalStorage.RemoveAll();
        }
    }
}
