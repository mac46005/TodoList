CREATE PROCEDURE [dbo].[spCompletedItems_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id,ToDoItem_ID,DateTimeCompleted,Category_ID
	FROM CompletedItems
END