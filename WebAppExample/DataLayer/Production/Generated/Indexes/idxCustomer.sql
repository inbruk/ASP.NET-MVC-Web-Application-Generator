CREATE INDEX idxCustomer_PersonFirstName 
    ON [tblCustomer]([PersonFirstName]); 
GO

CREATE INDEX idxCustomer_PersonSurname 
    ON [tblCustomer]([PersonSurname]); 
GO

CREATE INDEX idxCustomer_PersonPatronymicName 
    ON [tblCustomer]([PersonPatronymicName]); 
GO

CREATE INDEX idxCustomer_PersonGender 
    ON [tblCustomer]([PersonGender]); 
GO

CREATE INDEX idxCustomer_PersonMaritalStatus 
    ON [tblCustomer]([PersonMaritalStatus]); 
GO

CREATE INDEX idxCustomer_PersonBirthDate 
    ON [tblCustomer]([PersonBirthDate]); 
GO

CREATE INDEX idxCustomer_PersonContactsActualAddress 
    ON [tblCustomer]([PersonContactsActualAddress]); 
GO

CREATE INDEX idxCustomer_PersonContactsPersonalMobilePhone 
    ON [tblCustomer]([PersonContactsPersonalMobilePhone]); 
GO

CREATE INDEX idxCustomer_PersonContactsWorkMobilePhone 
    ON [tblCustomer]([PersonContactsWorkMobilePhone]); 
GO

CREATE INDEX idxCustomer_PersonContactsHomePhone 
    ON [tblCustomer]([PersonContactsHomePhone]); 
GO

CREATE INDEX idxCustomer_PersonContactsWorkPhone 
    ON [tblCustomer]([PersonContactsWorkPhone]); 
GO

CREATE INDEX idxCustomer_PersonContactsPersonalEMail 
    ON [tblCustomer]([PersonContactsPersonalEMail]); 
GO

CREATE INDEX idxCustomer_PersonContactsWorkEMail 
    ON [tblCustomer]([PersonContactsWorkEMail]); 
GO

CREATE INDEX idxCustomer_PersonContactsMessenger1 
    ON [tblCustomer]([PersonContactsMessenger1]); 
GO

CREATE INDEX idxCustomer_PersonContactsMessenger2 
    ON [tblCustomer]([PersonContactsMessenger2]); 
GO

CREATE INDEX idxCustomer_PersonContactsMessenger3 
    ON [tblCustomer]([PersonContactsMessenger3]); 
GO

CREATE INDEX idxCustomer_PaymentAccountBalance 
    ON [tblCustomer]([PaymentAccountBalance]); 
GO

CREATE INDEX idxCustomer_PaymentAccountAccountState 
    ON [tblCustomer]([PaymentAccountAccountState]); 
GO

