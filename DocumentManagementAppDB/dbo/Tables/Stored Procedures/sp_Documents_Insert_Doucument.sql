CREATE PROCEDURE [dbo].[sp_Documents_Insert_Doucument]
	@title nvarchar(50),
    @description nvarchar(MAX) ,
    @publishDate date,
	@mentorId int

AS
begin 
	set nocount on
		insert into dbo.Documents(Title,Description,PublishDate,MentorId)
		values (@title,@description,@publishDate,@mentorId)
end

