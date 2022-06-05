using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myScriptureJournal.Models;

using Microsoft.AspNetCore.Mvc.Rendering;
namespace myScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesScriptureContext _context;

        public IndexModel(RazorPagesScriptureContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        

        [BindProperty(SupportsGet = true)]
        public string NoteSearchString { get; set; }

        public async Task OnGetAsync()
        {
            var scriptures = from s in _context.Scripture
                                    select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            } 
            
            if(!String.IsNullOrEmpty(NoteSearchString))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(NoteSearchString));
            } 

            Scripture = await scriptures.ToListAsync();
        }
    }
}
