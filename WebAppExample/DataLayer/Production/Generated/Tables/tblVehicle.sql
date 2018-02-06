CREATE TABLE tblVehicle ( 
    Id BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
    Comment NVARCHAR(MAX),
    Brand BIGINT FOREIGN KEY REFERENCES tblDirectoryValue(Id),
    Model NVARCHAR(16),
    DriverOwner BIGINT FOREIGN KEY REFERENCES tblDriver(Id),
 ); 
GO
