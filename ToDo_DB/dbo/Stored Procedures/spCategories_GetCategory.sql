CREATE PROCEDURE [dbo].[spCategories_GetCategory]
	@ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id,Name
	FROM Categories
	WHERE Id = @ID
END