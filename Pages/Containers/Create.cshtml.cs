using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SPHackathon.Data;
using SPHackathon.Models;
using SPHackathon.Models.Documents.Legal;
using SPHackathon.Models.Documents.Misc;

namespace SPHackathon.Pages.Containers
{
    public class CreateModel : PageModel
    {
        #region Private Fields

        private readonly SPHackathon.Data.ApplicationDbContext _context;

        #endregion Private Fields

        #region Public Constructors

        public CreateModel(SPHackathon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Properties

        [BindProperty]
        public Container Container { get; set; }

        #endregion Public Properties

        #region Public Methods

        public IActionResult OnGet()
        {
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

            Container.LandBookRegistrations = new List<LandBookRegistration>();
            Container.Letters = new List<Letter>();
            _context.Container.Add(Container);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }

        #endregion Public Methods
    }
}