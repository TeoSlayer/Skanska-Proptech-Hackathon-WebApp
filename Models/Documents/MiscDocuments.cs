using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SPHackathon.Models.Documents.Misc
{
    public class Letter
    {
        #region Public Properties

        public DateTime Date { get; set; }
        public DateTime DateAdded { get; set; }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string InAttentionOf { get; set; }
        public string Name { get; set; }
        public string PhysicalPath { get; set; }
        public string Recipient { get; set; }
        public string RecipientAddress { get; set; }
        public string Sender { get; set; }

        #endregion Public Properties
    }
}