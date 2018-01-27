CREATE VIEW vwOrderDriver
AS
SELECT 
    Id, 
    Comment, 
    StartDateTime, 
    ControlDateTime, 
    CloseDateTime, 
    Customer, 
    Driver, 
FROM tblOrder Ord
LEFT JOIN tblDriver Drv ON Ord.Driver=Drv.Order
GO
