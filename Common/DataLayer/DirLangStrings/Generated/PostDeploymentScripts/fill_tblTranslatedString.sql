
IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=1 AND Value='Должность' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 1, 1, 'Должность', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=1 AND Value='Водитель' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 1, 'Водитель', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=1 AND Value='Управляет машинами компании. Возит клиентов.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 1, 'Управляет машинами компании. Возит клиентов.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=2 AND Value='Диспетчер' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 2, 'Диспетчер', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=2 AND Value='Звонит водителям и клиентам. Сохраняет заказы в БД.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 2, 'Звонит водителям и клиентам. Сохраняет заказы в БД.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=3 AND Value='Супервизор' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 3, 'Супервизор', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=3 AND Value='Пасет диспетчеров. Решает конфликтные ситуации с клиентами и водителями.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 3, 'Пасет диспетчеров. Решает конфликтные ситуации с клиентами и водителями.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=2 AND Value='Пол' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 1, 2, 'Пол', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=4 AND Value='Мужской' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 4, 'Мужской', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=4 AND Value='Мальчики, юноши, мужчины, дедушки.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 4, 'Мальчики, юноши, мужчины, дедушки.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=5 AND Value='Женский' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 5, 'Женский', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=5 AND Value='Девочки, девушки, женщины, бабушки.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 5, 'Девочки, девушки, женщины, бабушки.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=3 AND Value='Семейное положение' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 1, 3, 'Семейное положение', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=6 AND Value='Холост/Не замужем' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 6, 'Холост/Не замужем', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=6 AND Value='Отношения официально не оформлены.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 6, 'Отношения официально не оформлены.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=7 AND Value='Женат/За мужем' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 7, 'Женат/За мужем', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=7 AND Value='Отношения официально оформлены.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 7, 'Отношения официально оформлены.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=4 AND Value='Состояние аккаунта' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 1, 4, 'Состояние аккаунта', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=8 AND Value='Рабочий' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 8, 'Рабочий', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=8 AND Value='Аккаунт можно использовать.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 8, 'Аккаунт можно использовать.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=9 AND Value='Заблокирован' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 9, 'Заблокирован', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=9 AND Value='Сейчас пользоваться аккаунтом нельзя.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 9, 'Сейчас пользоваться аккаунтом нельзя.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=5 AND Value='Бренд автопроизводителя' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 1, 5, 'Бренд автопроизводителя', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=10 AND Value='ВАЗ' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 10, 'ВАЗ', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=10 AND Value='Российская разбитная бричка.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 10, 'Российская разбитная бричка.', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=11 AND Value='ГАЗ' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 2, 11, 'ГАЗ', 0 );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=11 AND Value='Колесница богов.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value, IsDeleted )
    VALUES
        ( 1, 3, 11, 'Колесница богов.', 0 );
END
