using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SPHackathon.Models.Documents.Legal
{
    public class LandBookRegistration
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        public DateTime DateIssued { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Issuer { get; set; }
        public string IssuerSpecialty { get; set; }
        public string LandBookNumber { get; set; }
        public string Name { get; set; }
        public string PhysicalPath { get; set; }
        public int RequestNumber { get; set; }

        #endregion Public Properties
    }
}