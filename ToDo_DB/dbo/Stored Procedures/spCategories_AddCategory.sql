CREATE PROCEDURE [dbo].[spCategories_AddCategory]
	@Name NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Categories(Name)
	VALUES(@Name)
END