CREATE PROCEDURE [dbo].[spCategories_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id,Name
	FROM Categories
END