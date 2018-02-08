CREATE TABLE tblVehicle ( 
    Id BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
    Comment NVARCHAR(MAX),
    Brand BIGINT,
    Model NVARCHAR(16),
    DriverOwner BIGINT FOREIGN KEY REFERENCES tblDriver(Id),
 ); 
GO
