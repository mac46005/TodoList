CREATE PROCEDURE [dbo].[spToDoItems_AddToDoItem]
	@ToDo NVARCHAR(50),
	@DueDate DATETIME2,
	@IsCompleted BIT,
	@Category_ID int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO ToDoItems(ToDo,DueDate,IsComplete,Category_ID)
	VALUES(@ToDo,@DueDate,@IsCompleted,@Category_ID)
END