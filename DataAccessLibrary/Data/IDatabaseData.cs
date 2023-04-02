using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IDatabaseData
    {
        List<DocumentViewModel> DisplayDocuments();
        void InsertDocument(string title, string description, DateTime publishDate, string firstName, string lastName, string position);
        void RemoveDocumentById(int id);
        List<DocumentViewModel> SearchDocument(string title);
        DocumentViewModel ViewDocumentById(int id);
    }
}