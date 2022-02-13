CREATE PROCEDURE [dbo].[spCompletedItems_DeleteCompletedItem]
	@ID int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM CompletedItems
	WHERE Id = @ID
END