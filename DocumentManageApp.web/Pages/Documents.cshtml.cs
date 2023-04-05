using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;

namespace DocumentManageApp.web.Pages.Shared
{
    public class DocumentModel : PageModel
    {
        private readonly IDatabaseData _db;

        public DocumentModel(IDatabaseData db)
        {
            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }

        public List<DocumentViewModel> Documents { get; set; }


        [BindProperty(SupportsGet = true)]
        public bool SearchEnabled { get; set; } = false;

        public void OnGet()
        {
            if (SearchEnabled == true)
            {
                Documents = _db.SearchDocument(Title);
            }
            else
            {
                Documents = _db.DisplayDocuments();
            }


        }
        public IActionResult OnPost()
        {
            return RedirectToPage(new 
            { 
                SearchEnabled = true, 
                Title
            });
        }
        public  IActionResult OnPostDelete(int id)
        {
            var document = _db.ViewDocumentById(id) ;
            if (document == null)
            {
                return NotFound();
            }

            _db.RemoveDocumentById(document.Id);
            return RedirectToPage();
        }

    }


}
