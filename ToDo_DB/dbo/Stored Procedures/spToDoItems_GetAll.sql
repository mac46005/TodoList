CREATE PROCEDURE [dbo].[spToDoItems_GetAll]
	@Category_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id,ToDo,DueDate,IsComplete,Category_ID
	FROM ToDoItems
	WHERE Category_ID = @Category_ID

END
