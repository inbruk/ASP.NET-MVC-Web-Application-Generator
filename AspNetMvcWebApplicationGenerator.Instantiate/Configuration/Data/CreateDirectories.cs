namespace AspNetMvcWebApplicationGenerator.Instantiate.Configuration.Data
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    public static class Directories
    {
        public static void Create()
        {
            DataConfiguration.AddDirectory
            (
                new Directory
                ( 
                     "Position",
                     true,
                     new Dictionary<long, string>() { { 1, "Должность" } },
                     new List<DirectoryItem>()
                     {
                         new DirectoryItem
                         ( 
                             1, 
                             "Driver", 
                             true,
                             new Dictionary<long, string>() { { 1, "Водитель" } },
                             new Dictionary<long, string>() { { 1, "Управляет машинами компании. Возит клиентов." } }
                         ),
                         new DirectoryItem
                         (
                             2,
                             "Dispatcher",
                             true,
                             new Dictionary<long, string>() { { 1, "Диспетчер" } },
                             new Dictionary<long, string>() { { 1, "Звонит водителям и клиентам. Сохраняет заказы в БД." } }
                         ),
                         new DirectoryItem
                         (
                             3,
                             "Superviser",
                             true,
                             new Dictionary<long, string>() { { 1, "Супервизор" } },
                             new Dictionary<long, string>() { { 1, "Пасет диспетчеров. Решает конфликтные ситуации с клиентами и водителями." } }
                         )
                     }
                )
            );
        }
    }
}
