CREATE PROCEDURE [dbo].[sp_Mentors_Insert_Mentor]
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@position nvarchar(20)
AS
begin
	set nocount on
	if not exists (select 1 from dbo.Mentors where (FirstName = @firstName and LastName = @lastName))
	begin
		insert into dbo.Mentors (FirstName,LastName,Position)
		values (@firstName,@lastName,@position)
	end
	select top 1 [Id], [FirstName], [LastName], [Position]
	from dbo.Mentors 
	where (FirstName = @firstName and LastName = @lastName)
end