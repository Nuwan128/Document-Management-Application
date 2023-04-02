CREATE TABLE [dbo].[Documents]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [PublishDate] DATE NOT NULL, 
    [MentorId] INT NOT NULL, 
    CONSTRAINT [FK_Documents_Mentors] FOREIGN KEY (MentorId) REFERENCES Mentors(Id)
)
