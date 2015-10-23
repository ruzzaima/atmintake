IF OBJECT_ID('Sph.EntityForm', 'U') IS NOT NULL
  DROP TABLE Sph.EntityForm
GO

CREATE TABLE [Sph].[EntityForm]
(
	[Id] VARCHAR(50) PRIMARY KEY NOT NULL
	,[EntityDefinitionId] VARCHAR(255) NOT NULL 
	,[Entity] VARCHAR(255) NOT NULL DEFAULT ''
	,[Json] VARCHAR(MAX) NOT NULL
	,[IsPublished] BIT NOT NULL
	,[IsAllowedNewItem] BIT NOT NULL
	,[IsDefault] BIT NOT NULL
	,[Name] VARCHAR(255) NOT NULL
	,[Route] VARCHAR(255) NOT NULL
	,[CreatedDate] SMALLDATETIME NOT NULL DEFAULT GETDATE()
	,[CreatedBy] VARCHAR(255) NULL
	,[ChangedDate] SMALLDATETIME NOT NULL DEFAULT GETDATE()
	,[ChangedBy] VARCHAR(255) NULL
)
GO 
