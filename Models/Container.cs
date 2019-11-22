using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SPHackathon.Models
{
    public class Container
    {
        #region Public Properties

        public string ApprovedUsers { get; set; }

        public string ContainerName { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public List<Documents.Legal.LandBookRegistration> LandBookRegistrations { get; set; }
        public string LeadReviewer { get; set; }
        public List<Documents.Misc.Letter> Letters { get; set; }
        public string ProjectLead { get; set; }

        #endregion Public Properties
    }
}