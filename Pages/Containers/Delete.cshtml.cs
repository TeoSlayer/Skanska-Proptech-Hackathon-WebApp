using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SPHackathon.Data;
using SPHackathon.Models;

namespace SPHackathon.Pages.Containers
{
    public class DeleteModel : PageModel
    {
        #region Private Fields

        private readonly SPHackathon.Data.ApplicationDbContext _context;

        #endregion Private Fields

        #region Public Constructors

        public DeleteModel(SPHackathon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Properties

        [BindProperty]
        public Container Container { get; set; }

        #endregion Public Properties

        #region Public Methods

        public async Task<IActionResult> OnGetAsync(string ContainerID)
        {
            string id = ContainerID;
            if (id == null)
            {
                return NotFound();
            }

            Container = await _context.Container.FirstOrDefaultAsync(m => m.ID == id);

            if (Container == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string ContainerID)
        {
            string id = ContainerID;
            if (id == null)
            {
                return NotFound();
            }

            Container = await _context.Container.FindAsync(id);

            if (Container != null)
            {
                _context.Container.Remove(Container);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

        #endregion Public Methods
    }
}