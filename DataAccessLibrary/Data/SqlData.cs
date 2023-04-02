using DataAccessLibrary.Databases;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class SqlData : IDatabaseData
    {
        private readonly ISqlDataAccess _db;
        private readonly string connectionStringName = "SqlDb";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }

        public void InsertDocument(string title,
                                   string description,
                                   DateTime publishDate,
                                   string firstName,
                                   string lastName,
                                   string position)
        {
            MentorModel mentor = _db.LoadData<MentorModel, dynamic>("dbo.sp_Mentors_Insert_Mentor",
                                                                    new { firstName, lastName, position },
                                                                    connectionStringName,
                                                                    true).First();

            _db.SaveData("dbo.sp_Documents_Insert_Doucument",
                         new
                         {
                             title,
                             description,
                             publishDate,
                             mentorId = mentor.Id,
                         },
                         connectionStringName,
                         true);
        }

        public List<DocumentViewModel> SearchDocument(string title)
        {
            return _db.LoadData<DocumentViewModel, dynamic>("dbo.spDocuments_Search_Document",
                                                            new 
                                                            { 
                                                                title 
                                                            },
                                                            connectionStringName,
                                                            true);
        }
        public List<DocumentViewModel> DisplayDocuments()
        {
            string sql = @"select [d].[Id], [d].[Title], [d].[Description], [d].[PublishDate], [d].[MentorId],
		            [m].[FirstName], [m].[LastName], [m].[Position]
		            from dbo.Documents d
		            inner join dbo.Mentors m on d.MentorId = m.Id
                    order by d.PublishDate desc";

            return _db.LoadData<DocumentViewModel, dynamic>(sql, new { }, connectionStringName, false);
        }

        public void RemoveDocumentById(int id)
        {
            string sql = @"delete from dbo.Documents  where Id = @id";
            _db.SaveData(sql, new { id },connectionStringName,false);
        }

        public DocumentViewModel ViewDocumentById(int id)
        {
            string sql = @" select [d].[Id], [d].[Title], [d].[Description], [d].[PublishDate], [d].[MentorId],
                            [m].[FirstName], [m].[LastName], [m].[Position]
                            from dbo.Documents d
                            inner join dbo.Mentors m on d.MentorId = m.Id  
                            where d.Id = @id";

            return _db.LoadData<DocumentViewModel,dynamic>(sql,new { id },connectionStringName,false).First();
        }
    }
}
