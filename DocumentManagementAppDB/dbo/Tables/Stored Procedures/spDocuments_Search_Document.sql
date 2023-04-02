CREATE PROCEDURE [dbo].[spDocuments_Search_Document]
	@title nvarchar(50)
	
AS
	
begin
	set nocount on

		select [d].[Id], [d].[Title], [d].[Description], [d].[PublishDate], [d].[MentorId],
		[m].[FirstName], [m].[LastName], [m].[Position]
		from dbo.Documents d 
		inner join dbo.Mentors m on d.MentorId = m.Id
		where d.Title like '%'+@title+'%'
		order by d.PublishDate desc
end
