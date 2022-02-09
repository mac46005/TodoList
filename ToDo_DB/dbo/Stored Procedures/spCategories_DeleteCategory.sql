CREATE PROCEDURE [dbo].[spCategories_DeleteCategory]
	@ID int
AS
	SET NOCOUNT ON;

	DELETE FROM Categories
	WHERE Id = @ID
RETURN 0
