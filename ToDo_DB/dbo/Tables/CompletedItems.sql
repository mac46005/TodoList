CREATE TABLE [dbo].[CompletedItems]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ToDoItem_ID] INT NOT NULL, 
    [DateTimeCompleted] DATETIME2 NOT NULL, 
    [Category_ID] INT NOT NULL
)
