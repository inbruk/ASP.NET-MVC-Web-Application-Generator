namespace Auxiliary.StorageTools
{
    using System;
    using System.Web;
    using System.Web.SessionState;

    public static class StoragePerUser
    {
        public static HttpSessionState internalStorage { get { return HttpContext.Current.Session; } }

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
