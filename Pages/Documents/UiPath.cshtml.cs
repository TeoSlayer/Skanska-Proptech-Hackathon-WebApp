using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
    public class UiPathModel : PageModel
    {
        #region Private Fields

        private readonly SPHackathon.Data.ApplicationDbContext _context;

        #endregion Private Fields

        #region Public Constructors

        public UiPathModel(SPHackathon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Properties

        public Container Container { get; set; }

        [BindProperty]
        public LandAndLetter landAndLetter { get; set; }

        [BindProperty]
        public IFormFile UploadFile { get; set; }

        #endregion Public Properties

        #region Public Methods

        public async Task<IActionResult> OnGetAsync()
        {
            Container = await _context.Container.Include(c => c.LandBookRegistrations).Include(c => c.Letters).Where(c => c.ID == "4f9d6779-fa91-4a82-a5be-657fe8f52dd9").FirstAsync();

            //LandBookRegistration.DateAdded = DateTime.Now;
            //Letter.DateAdded = DateTime.Now;

            LandBookRegistration LandBook = new LandBookRegistration();
            LandBook.PhysicalPath = "mwna1wqq.nzr2.3.2.2.3_DLT_20190513_L_ANCPI_EXTRAS_DE_CARTE_FUNCIARA_NR._234644_Informare_38077.pdf";
            LandBook.Issuer = "Oficiul de Cadastru şi Publicitate Imobiliară BUCURESTI";
            LandBook.IssuerSpecialty = "Biroul de Cadastru şi Publicitate Imobiliară Sectorul 6";
            LandBook.RequestNumber = 38077;
            LandBook.LandBookNumber = "234644";

            Container.LandBookRegistrations.Add(LandBook);

            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("/Index");
        }

        #endregion Public Methods

        #region Public Classes

        public class LandAndLetter
        {
            #region Public Properties

            public LandBookRegistration LandBookRegistration
            {
                get; set;
            }

            public Letter Letter { get; set; }

            #endregion Public Properties
        }

        #endregion Public Classes
    }
}