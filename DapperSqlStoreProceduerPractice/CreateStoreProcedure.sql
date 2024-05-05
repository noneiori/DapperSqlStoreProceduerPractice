CREATE PROCEDURE GetQandAById
	@id int
AS
BEGIN
	SELECT * FROM [dbo].[QandA] WHERE [id] = @id;
END;
