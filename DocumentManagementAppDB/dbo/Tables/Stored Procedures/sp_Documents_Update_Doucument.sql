CREATE PROCEDURE [dbo].[sp_Documents_Update_Doucument]
	@id int ,
	@title nvarchar(50),
    @description nvarchar(MAX) ,
    @publishDate date,
	@mentorId int
As
begin
	set nocount on

		update dbo.Documents 
		set 
			Title = @title,
			Description = @description,
			PublishDate = @publishDate, 
			MentorId = @mentorId

		where Id = @id

end
