IF OBJECT_ID('Sph.Tracker', 'U') IS NOT NULL
  DROP TABLE Sph.Tracker
GO

CREATE TABLE [Sph].[Tracker]
(
	[Id] VARCHAR(255) PRIMARY KEY NOT NULL
	,[WorkflowId] VARCHAR(50) NOT NULL
	,[WorkflowDefinitionId] VARCHAR(255) NULL
	,[Json] VARCHAR(MAX) NOT NULL
	,[CreatedDate] SMALLDATETIME NOT NULL DEFAULT GETDATE()
	,[CreatedBy] VARCHAR(255) NULL
	,[ChangedDate] SMALLDATETIME NOT NULL DEFAULT GETDATE()
	,[ChangedBy] VARCHAR(255) NULL
)
GO 
