CREATE PROCEDURE [dbo].[spCompletedItem_UpdateCompletedItem]
	@ID int,
	@ToDoItem_ID int,
	@DateTimeCompleted DATETIME2,
	@Category_ID int

AS
BEGIN
	SET NOCOUNT ON;

	UPDATE CompletedItems
	SET 
	ToDoItem_ID = @ToDoItem_ID,
	DateTimeCompleted = @DateTimeCompleted,
	Category_ID = @Category_ID

	WHERE Id = @ID
END