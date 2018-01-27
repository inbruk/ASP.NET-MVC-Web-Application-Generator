CREATE TABLE tblVehicle ( 
    Id BIGINT,
    Comment NVARCHAR(MAX),
    Brand BIGINT FOREIGN KEY REFERENCES tblDirectoryValue(Id),
    Model NVARCHAR(16),
    DriverOwner BIGINT FOREIGN KEY REFERENCES tblDriver(Id),
 ); 
GO
