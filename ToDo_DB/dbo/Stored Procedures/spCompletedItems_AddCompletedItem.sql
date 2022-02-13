CREATE PROCEDURE [dbo].[spCompletedItems_AddCompletedItem]
	@ID int,
	@ToDoItem_ID int,
	@DateTimeCompleted DATETIME2,
	@Category_ID int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO CompletedItems(ToDoItem_ID,DateTimeCompleted,Category_ID)
	VALUES(@ToDoItem_ID,@DateTimeCompleted,@Category_ID)
END