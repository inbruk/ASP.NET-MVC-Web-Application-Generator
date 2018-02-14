namespace Auxiliary.StorageTools
{
    using System;
    using System.Web;

    public static class StoragePerApplication
    {
        public static HttpApplicationState internalStorage { get { return HttpContext.Current.Application; } }
            
        public static Object Get(String index)
        {
            return (Object)internalStorage[index];
        }

        public static void Put(String index, Object value)
        {
            internalStorage[index] = value;
        }

        public static void Remove(String index)
        {
            internalStorage.Remove(index);
        }

        public static void ClearAll()
        {
            internalStorage.RemoveAll();
        }
    }
}
