CREATE TABLE [dbo].[ToDoItems]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ToDo] NVARCHAR(150) NOT NULL, 
    [DueDate] DATETIME2 NOT NULL, 
    [IsComplete] BIT NOT NULL,
    [Category_ID] INT NOT NULL, 
    CONSTRAINT [FK_ToDoItems_ToCategories] FOREIGN KEY ([Category_ID]) REFERENCES [Categories]([Id])
)
