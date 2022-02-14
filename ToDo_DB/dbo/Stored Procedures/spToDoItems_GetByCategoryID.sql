CREATE PROCEDURE [dbo].[spToDoItems_GetByCategoryID]
	@CategoryID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id,ToDo,DueDate,IsComplete,Category_ID
	FROM ToDoItems
	WHERE Category_ID = @CategoryID
END