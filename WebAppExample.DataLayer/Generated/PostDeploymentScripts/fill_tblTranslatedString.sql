
IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=1 AND Value='Должность' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 1, 1, 'Должность' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=1 AND Value='Водитель' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 1, 'Водитель' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=1 AND Value='Управляет машинами компании. Возит клиентов.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 1, 'Управляет машинами компании. Возит клиентов.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=2 AND Value='Диспетчер' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 2, 'Диспетчер' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=2 AND Value='Звонит водителям и клиентам. Сохраняет заказы в БД.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 2, 'Звонит водителям и клиентам. Сохраняет заказы в БД.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=3 AND Value='Супервизор' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 3, 'Супервизор' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=3 AND Value='Пасет диспетчеров. Решает конфликтные ситуации с клиентами и водителями.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 3, 'Пасет диспетчеров. Решает конфликтные ситуации с клиентами и водителями.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=2 AND Value='Пол' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 1, 2, 'Пол' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=4 AND Value='Мужской' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 4, 'Мужской' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=4 AND Value='Мальчики, юноши, мужчины, дедушки.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 4, 'Мальчики, юноши, мужчины, дедушки.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=5 AND Value='Женский' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 5, 'Женский' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=5 AND Value='Девочки, девушки, женщины, бабушки.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 5, 'Девочки, девушки, женщины, бабушки.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=3 AND Value='Семейное положение' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 1, 3, 'Семейное положение' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=6 AND Value='Холост/Не замужем' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 6, 'Холост/Не замужем' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=6 AND Value='Отношения официально не оформлены.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 6, 'Отношения официально не оформлены.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=7 AND Value='Женат/За мужем' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 7, 'Женат/За мужем' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=7 AND Value='Отношения официально оформлены.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 7, 'Отношения официально оформлены.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=4 AND Value='Состояние аккаунта' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 1, 4, 'Состояние аккаунта' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=8 AND Value='Рабочий' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 8, 'Рабочий' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=8 AND Value='Аккаунт можно использовать.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 8, 'Аккаунт можно использовать.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=9 AND Value='Заблокирован' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 9, 'Заблокирован' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=9 AND Value='Сейчас пользоваться аккаунтом нельзя.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 9, 'Сейчас пользоваться аккаунтом нельзя.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=1 AND 
          ReferencedItemId=5 AND Value='Бренд автопроизводителя' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 1, 5, 'Бренд автопроизводителя' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=10 AND Value='ВАЗ' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 10, 'ВАЗ' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=10 AND Value='Российская разбитная бричка.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 10, 'Российская разбитная бричка.' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=2 AND 
          ReferencedItemId=11 AND Value='ГАЗ' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 2, 11, 'ГАЗ' );
END

IF NOT EXISTS( SELECT * FROM tblTranslatedString
    WHERE Language=1 AND Type=3 AND 
          ReferencedItemId=11 AND Value='Колесница богов.' )
BEGIN
    INSERT INTO tblTranslatedString 
        ( Language, Type, ReferencedItemId, Value )
    VALUES
        ( 1, 3, 11, 'Колесница богов.' );
END
