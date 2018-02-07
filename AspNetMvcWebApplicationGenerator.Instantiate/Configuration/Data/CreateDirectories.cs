namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.Data
{
    using System;
    using System.Collections.Generic;

    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    internal static class CreateDirectories
    {
        public static void Create()
        {
            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     1,
                     "Position",
                     true,
                     new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryName, 1, "Должность" ) },
                     new List<DirectoryValue>()
                     {
                         new DirectoryValue
                         (
                             1,
                             "Driver",
                             true,
                             1,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 1, "Водитель" ) },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 1, "Управляет машинами компании. Возит клиентов." )
                             }
                         ),
                         new DirectoryValue
                         (
                             2,
                             "Dispatcher",
                             true,
                             1,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 2, "Диспетчер") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 2, "Звонит водителям и клиентам. Сохраняет заказы в БД." )
                             }
                         ),
                         new DirectoryValue
                         (
                             3,
                             "Superviser",
                             true,
                             1,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 3, "Супервизор") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 3, 
                                    "Пасет диспетчеров. Решает конфликтные ситуации с клиентами и водителями." )
                             }
                         )
                     }
                )
            );

            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     2,
                     "Gender",
                     true,
                     new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryName, 2, "Пол") },
                     new List<DirectoryValue>()
                     {
                         new DirectoryValue
                         (
                             4,
                             "Male",
                             true,
                             2,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 4, "Мужской") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 4, "Мальчики, юноши, мужчины, дедушки." )
                             }
                         ),
                         new DirectoryValue
                         (
                             5,
                             "Female",
                             true,
                             2,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 5, "Женский") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 5, "Девочки, девушки, женщины, бабушки." )
                             }
                         )
                     }
                )
            );

            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     3, 
                     "MaritalStatus",
                     true,
                     new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryName, 3, "Семейное положение" ) },
                     new List<DirectoryValue>()
                     {
                         new DirectoryValue
                         (
                             6,
                             "Single",
                             true,
                             3,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 6, "Холост/Не замужем") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 6, "Отношения официально не оформлены." )
                             }
                         ),
                         new DirectoryValue
                         (
                             7,
                             "Married",
                             true,
                             3,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 7, "Женат/За мужем") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 7, "Отношения официально оформлены." )
                             }
                         )
                     }
                )
            );

            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     4,
                     "AccountState",
                     true,
                     new List<TranslatedString>() { new TranslatedString(1, TranslatedStringType.DirectoryName, 4, "Состояние аккаунта") },
                     new List<DirectoryValue>()
                     {
                         new DirectoryValue
                         (
                             8,
                             "Working",
                             true,
                             4,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 8, "Рабочий") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 8, "Аккаунт можно использовать." )
                             }
                         ),
                         new DirectoryValue
                         (
                             9,
                             "Blocked",
                             true,
                             4,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 9, "Заблокирован") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 9, "Сейчас пользоваться аккаунтом нельзя." )
                             }
                         )
                     }
                )
            );

            DataConfiguration.AddDirectory
            (
                new Directory
                (
                     5, 
                     "VehicleBrand",
                     true,
                     new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryName, 5, "Бренд автопроизводителя" ) },
                     new List<DirectoryValue>()
                     {
                         new DirectoryValue
                         (
                             10,
                             "LADA",
                             true,
                             5,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 10, "ВАЗ") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 10, "Российская разбитная бричка." )
                             }
                         ),
                         new DirectoryValue
                         (
                             11,
                             "GAZ",
                             true,
                             5,
                             new List<TranslatedString>() { new TranslatedString( 1, TranslatedStringType.DirectoryItemValue, 11, "ГАЗ") },
                             new List<TranslatedString>()
                             {
                                 new TranslatedString( 1, TranslatedStringType.DirectoryItemComment, 11, "Колесница богов." )
                             }
                         )
                     }
                )
            );
        }
    }
}
