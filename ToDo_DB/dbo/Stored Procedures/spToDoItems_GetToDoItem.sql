CREATE PROCEDURE [dbo].[spToDoItems_GetToDoItem]
	@ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id,Todo,DueDate,IsComplete,Category_ID
	FROM ToDoItems
	WHERE Id = @ID
END