CREATE TABLE [dbo].[Faculty]
(
	[fID] INT NOT NULL IDENTITY, 
    [fName] NVARCHAR(50) NULL, 
    [deptID] INT NULL, 
    [standing] NVARCHAR(50) NULL

    CONSTRAINT [FK_Faculty] PRIMARY KEY ([fID])
)
