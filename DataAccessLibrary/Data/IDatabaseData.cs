using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IDatabaseData
    {
        List<DocumentViewModel> DisplayDocuments();
        void InsertDocument(string title, string description, DateTime publishDate, string firstName, string lastName, string position);
        void RemoveDocumentById(int id);
        List<DocumentViewModel> SearchDocument(string title);
        void UpdateDocument(int id, string title, string description, DateTime publishDate, string firstName, string lastName, string position);
        DocumentViewModel ViewDocumentById(int id);
    }
}