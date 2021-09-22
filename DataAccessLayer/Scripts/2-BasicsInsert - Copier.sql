USE [RmConfig]
GO

INSERT INTO [dbo].[Right]
           ([Label])
     VALUES
           ('CREATE'),
           ('READ'),
           ('DELETE'),
           ('CLONE')
GO

INSERT INTO [dbo].[MetaEntityType]
           ([Label])
     VALUES
           ('INFRASTRUCTURE'),
           ('VARIABLE_INFRASTRUCTURE'),
           ('APPLICATION'),
           ('VARIABLE_APPLICATION'),
           ('CLIENT'),
           ('VARIABLE_CLIENT'),
           ('ENVIRONNEMENT'),
           ('VARIABLE_ENVIRONNEMENT'),
           ('VERSION'),
           ('VARIABLE_VERSION'),
           ('ROLE'),
           ('PERMISSION')
GO

