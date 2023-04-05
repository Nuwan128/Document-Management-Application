using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DocumentManageApp.web.Pages
{
    public class UpdateDocumentModel : PageModel
    {
        private readonly IDatabaseData _db;

        public UpdateDocumentModel(IDatabaseData db)
        {
            _db = db;
        }

        [BindProperty]
        public DocumentViewModel Document { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            _db.UpdateDocument(Id,
                               Document.Title,
                               Document.Description,
                               Document.PublishDate,
                               Document.FirstName,
                               Document.LastName,
                               Document.Position);

            return RedirectToPage("Documents");
        }
    }
}
