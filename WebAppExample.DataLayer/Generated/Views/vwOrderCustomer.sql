CREATE VIEW vwOrderCustomer
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
INNER JOIN tblCustomer Cust ON Ord.Customer=Cust.Id
GO
