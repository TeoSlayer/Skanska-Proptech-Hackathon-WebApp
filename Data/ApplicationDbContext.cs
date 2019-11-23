using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SPHackathon.Models;
using SPHackathon.Models.Documents.Legal;

namespace SPHackathon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        #region Public Constructors

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public DbSet<SPHackathon.Models.Container> Container { get; set; }

        #endregion Public Properties
    }
}