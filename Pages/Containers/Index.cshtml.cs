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
    public class IndexModel : PageModel
    {
        #region Private Fields

        private readonly SPHackathon.Data.ApplicationDbContext _context;

        #endregion Private Fields

        #region Public Constructors

        public IndexModel(SPHackathon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Properties

        public Container Container { get; set; }
        public string containerID { get; set; }
        public IQueryable<Container> Containers { get; set; }

        #endregion Public Properties

        #region Public Methods

        public async Task<IActionResult> OnGetAsync(string ContainerID)

        {
            containerID = ContainerID;
            Containers = _context.Container.Include(c => c.LandBookRegistrations).Include(c => c.Letters);
            Container = await Containers.Where(c => c.ID == ContainerID).FirstAsync();
            return Page();
        }

        #endregion Public Methods
    }
}