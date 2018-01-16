namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.Data
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    public static class CreateDirectories
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

            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     "Gender",
                     true,
                     new Dictionary<long, string>() { { 1, "Пол" } },
                     new List<DirectoryItem>()
                     {
                         new DirectoryItem
                         (
                             1,
                             "Male",
                             true,
                             new Dictionary<long, string>() { { 1, "Мужской" } },
                             new Dictionary<long, string>() { { 1, "Мальчики, юноши, мужчины, дедушки." } }
                         ),
                         new DirectoryItem
                         (
                             2,
                             "Female",
                             true,
                             new Dictionary<long, string>() { { 1, "Женский" } },
                             new Dictionary<long, string>() { { 1, "Девочки, девушки, женщины, бабушки." } }
                         )
                     }
                )
            );

            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     "MaritalStatus",
                     true,
                     new Dictionary<long, string>() { { 1, "Семейное положение" } },
                     new List<DirectoryItem>()
                     {
                         new DirectoryItem
                         (
                             1,
                             "Single",
                             true,
                             new Dictionary<long, string>() { { 1, "Холост" } },
                             new Dictionary<long, string>() { { 1, "Отношения официально не оформлены." } }
                         ),
                         new DirectoryItem
                         (
                             2,
                             "Married",
                             true,
                             new Dictionary<long, string>() { { 1, "Женат/За мужем" } },
                             new Dictionary<long, string>() { { 1, "Отношения официально оформлены." } }
                         )
                     }
                )
            );

            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     "AccountState",
                     true,
                     new Dictionary<long, string>() { { 1, "Состояние аккаунта" } },
                     new List<DirectoryItem>()
                     {
                         new DirectoryItem
                         (
                             1,
                             "Working",
                             true,
                             new Dictionary<long, string>() { { 1, "Рабочий" } },
                             new Dictionary<long, string>() { { 1, "Аккаунт можно использовать." } }
                         ),
                         new DirectoryItem
                         (
                             2,
                             "Blocked",
                             true,
                             new Dictionary<long, string>() { { 1, "Заблокирован" } },
                             new Dictionary<long, string>() { { 1, "Сейчас пользоваться аккаунтом нельзя." } }
                         )
                     }
                )
            );

            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     "VehicleBrand",
                     true,
                     new Dictionary<long, string>() { { 1, "Бренд автопроизводителя" } },
                     new List<DirectoryItem>()
                     {
                         new DirectoryItem
                         (
                             1,
                             "LADA",
                             true,
                             new Dictionary<long, string>() { { 1, "ВАЗ" } },
                             new Dictionary<long, string>() { { 1, "Российская разбитная бричка." } }
                         ),
                         new DirectoryItem
                         (
                             2,
                             "GAZ",
                             true,
                             new Dictionary<long, string>() { { 1, "ГАЗ" } },
                             new Dictionary<long, string>() { { 1, "Колесница богов." } }
                         )
                     }
                )
            );
        }
    }
}
