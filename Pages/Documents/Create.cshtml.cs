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

        public Container Container { get; set; }

        [BindProperty]
        public LandAndLetter landAndLetter { get; set; }

        [BindProperty]
        public IFormFile UploadFile { get; set; }

        #endregion Public Properties

        #region Public Methods

        public IActionResult OnGet()
        {
            landAndLetter = new LandAndLetter();
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string ContainerID, IFormFile UploadFile)
        {
            string randomFileName = Path.GetRandomFileName();
            UploadFile.CopyTo(new FileStream(@"uploads\" + randomFileName + UploadFile.FileName, FileMode.Create));

            Container = await _context.Container.Include(c => c.LandBookRegistrations).Include(c => c.Letters).Where(c => c.ID == ContainerID).FirstAsync();

            //LandBookRegistration.DateAdded = DateTime.Now;
            //Letter.DateAdded = DateTime.Now;

            landAndLetter.LandBookRegistration.PhysicalPath = randomFileName + UploadFile.FileName;
            landAndLetter.Letter.PhysicalPath = randomFileName + UploadFile.FileName;

            if (landAndLetter.LandBookRegistration.LandBookNumber != null)
                Container.LandBookRegistrations.Add(landAndLetter.LandBookRegistration);
            else if (landAndLetter.Letter.Recipient != null)
                Container.Letters.Add(landAndLetter.Letter);
            else
                return Page();

            await _context.SaveChangesAsync();

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