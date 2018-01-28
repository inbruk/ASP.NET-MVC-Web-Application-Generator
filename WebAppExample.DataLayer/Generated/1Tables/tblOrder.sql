CREATE TABLE tblOrder ( 
    Id BIGINT,
    Comment NVARCHAR(MAX),
    StartDateTime DATETIMEOFFSET,
    ControlDateTime DATETIMEOFFSET,
    CloseDateTime DATETIMEOFFSET,
    Customer BIGINT FOREIGN KEY REFERENCES tblCustomer(Id),
    -- see N2M link table n2mOrderDriver
 ); 
GO
