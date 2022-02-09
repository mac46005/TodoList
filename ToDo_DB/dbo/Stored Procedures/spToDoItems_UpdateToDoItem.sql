CREATE PROCEDURE [dbo].[spToDoItems_UpdateToDoItem]
	@ID int,
	@ToDo NVARCHAR(50),
	@DueDate DATETIME2,
	@IsComplete BIT,
	@Category_ID int

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE ToDoItems
	SET 
	ToDo = @ToDo,
	DueDate = @DueDate,
	IsComplete = @IsComplete,
	Category_ID = @Category_ID

	WHERE Id = @ID
END
