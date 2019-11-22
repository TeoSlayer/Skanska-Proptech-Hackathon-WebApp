using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPHackathon.Models.Documents.Asset
{
    public class FinancialStatement
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }
        public string PhysicalPath { get; set; }

        #endregion Public Properties
    }

    public class Insurance
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }
        public string PhysicalPath { get; set; }

        #endregion Public Properties
    }

    public class NDA
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }
        public string PhysicalPath { get; set; }

        #endregion Public Properties
    }

    public class PropertyInsurance
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }
        public string PhysicalPath { get; set; }

        #endregion Public Properties
    }

    public class Report
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }
        public string PhysicalPath { get; set; }

        #endregion Public Properties
    }

    public class ServiceChargeProposal
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }
        public string PhysicalPath { get; set; }

        #endregion Public Properties
    }

    public class Studies
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }
        public string PhysicalPath { get; set; }

        #endregion Public Properties
    }

    public class Warranty
    {
        #region Public Properties

        public DateTime DateAdded { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }
        public string PhysicalPath { get; set; }

        #endregion Public Properties
    }
}