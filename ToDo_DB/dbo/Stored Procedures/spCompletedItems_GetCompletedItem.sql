CREATE PROCEDURE [dbo].[spCompletedItems_GetCompletedItem]
	@ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id,ToDoItem_ID,DateTimeCompleted,Category_ID
	FROM CompletedItems
	WHERE Id = @ID
END