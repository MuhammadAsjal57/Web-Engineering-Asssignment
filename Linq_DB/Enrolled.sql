CREATE TABLE [dbo].[Enrolled]
(
	[ID] INT NOT NULL IDENTITY, 
    [sID] INT NULL, 
    [cID] INT NULL
    CONSTRAINT [FK_Enrolled] PRIMARY KEY ([ID])
    CONSTRAINT [FK_Enrolled_Student] FOREIGN KEY ([sID]) REFERENCES [Student]([sID])
    CONSTRAINT [FK_Enrolled_Class] FOREIGN KEY ([cID]) REFERENCES [Class]([cID])
)
