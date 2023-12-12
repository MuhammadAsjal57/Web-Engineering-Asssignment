CREATE TABLE [dbo].[Class]
(
	[cID] INT NOT NULL IDENTITY, 
    [name] NVARCHAR(50) NULL, 
    [roomNumber] NVARCHAR(50) NULL, 
    [fID] INT NULL

    CONSTRAINT [FK_Class] PRIMARY KEY ([cID])
    CONSTRAINT [FK_Class_Faculty] FOREIGN KEY ([fID]) REFERENCES [Faculty]([fID])
)
