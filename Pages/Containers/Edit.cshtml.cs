using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SPHackathon.Data;
using SPHackathon.Models;

namespace SPHackathon.Pages.Containers
{
    public class EditModel : PageModel
    {
        #region Private Fields

        private readonly SPHackathon.Data.ApplicationDbContext _context;

        #endregion Private Fields

        #region Public Constructors

        public EditModel(SPHackathon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Properties

        [BindProperty]
        public Container Container { get; set; }

        public string containerID { get; set; }

        #endregion Public Properties

        #region Public Methods

        public async Task<IActionResult> OnGetAsync(string ContainerID)
        {
            containerID = ContainerID;
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Container).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContainerExists(Container.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Index");
        }

        #endregion Public Methods

        #region Private Methods

        private bool ContainerExists(string id)
        {
            return _context.Container.Any(e => e.ID == id);
        }

        #endregion Private Methods
    }
}