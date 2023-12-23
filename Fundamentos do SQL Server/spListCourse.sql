CREATE OR ALTER PROCEDURE [spListCourse] 
    @CategoryId NVARCHAR(60)
AS
    SELECT * FROM [Course] WHERE [CategoryId] = @CategoryId