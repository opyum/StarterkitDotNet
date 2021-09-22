USE [RmConfig]
GO
INSERT INTO [dbo].[User]
           ([DisplayName]
           ,[LastName]
           ,[FirstName]
           ,[Email]
           ,[UserPrincipalName]
           ,[SamAccountName]
           ,[AzureObjectIdentifier]
           ,[CreatedDateTime]
           ,[CreatedBy]
           ,[ModifiedDateTime]
           ,[ModifiedBy])
     VALUES
           ('Flo'
           ,'LORCA'
           ,'Florian'
           ,'florca-ext@citegestion.fr'
           ,'UserPrincipalName'
           ,'SamAccountName'
           , NEWID() 
           ,GETDATE()
           , 'Flo'
            ,GETDATE()
           , 'Flo')
GO

INSERT INTO [dbo].[Role]
           ([Label])
     VALUES
           ('Administrateur'),
		   ('Utilisateur'),
		   ('Superviseur')

GO


INSERT INTO UserRole(
	IdRole, 
	IdUser
)
VALUES(1, 1)
GO


