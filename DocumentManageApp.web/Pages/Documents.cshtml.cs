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


            //Documents = _db.DisplayDocuments();


            Console.WriteLine("hi");

            //Documents = _db.SearchDocument(Title);

            if (SearchEnabled == true)
            {
                Console.WriteLine("hello");

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
    }


}
