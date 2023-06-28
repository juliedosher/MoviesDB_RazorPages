using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movies_RazorPages.Data;
using Movies_RazorPages.Models;

namespace Movies_RazorPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Movies_RazorPages.Data.Movies_RazorPagesContext _context;

        public IndexModel(Movies_RazorPages.Data.Movies_RazorPagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
