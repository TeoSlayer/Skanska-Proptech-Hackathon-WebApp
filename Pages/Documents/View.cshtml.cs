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
using SPHackathon.Models.Documents.Legal;
using SPHackathon.Models.Documents.Misc;

namespace SPHackathon.Pages.Documents
{
    public class ViewModel : PageModel
    {
        #region Private Fields

        private readonly SPHackathon.Data.ApplicationDbContext _context;

        #endregion Private Fields

        #region Public Constructors

        public ViewModel(SPHackathon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Properties

        public Container Container { get; set; }

        public string DocType { get; set; }

        [BindProperty]
        public LandBookRegistration LandBookRegistration { get; set; }

        [BindProperty]
        public Letter Letter { get; set; }

        #endregion Public Properties

        #region Public Methods

        public async Task<IActionResult> OnGetAsync(string id, string type, string ContainerID)
        {
            DocType = type;
            if (id == null)
            {
                return NotFound();
            }

            Container = await _context.Container.Include(c => c.LandBookRegistrations).Include(c => c.Letters).Where(c => c.ID == ContainerID).FirstAsync();

            if (type == "landBook")
                LandBookRegistration = Container.LandBookRegistrations.Find(l => l.PhysicalPath == id);
            else
                Letter = Container.Letters.Find(l => l.PhysicalPath == id);

            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("./Index");
        }

        #endregion Public Methods
    }
}