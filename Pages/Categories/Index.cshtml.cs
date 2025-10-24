using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Budalacean_Ciprian_Lab2.Data;
using Budalacean_Ciprian_Lab2.Models;

namespace Budalacean_Ciprian_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Budalacean_Ciprian_Lab2.Data.Budalacean_Ciprian_Lab2Context _context;

        public IndexModel(Budalacean_Ciprian_Lab2.Data.Budalacean_Ciprian_Lab2Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
