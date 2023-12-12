CREATE TABLE [dbo].[Student]
(
	[sID] INT NOT NULL IDENTITY, 
    [sName] NVARCHAR(50) NULL, 
    [major] NVARCHAR(50) NULL, 
    [standing] NVARCHAR(50) NULL

    CONSTRAINT [FK_Student] PRIMARY KEY ([sID])
)
