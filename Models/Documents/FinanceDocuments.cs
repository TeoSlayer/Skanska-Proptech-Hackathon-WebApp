using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SPHackathon.Models.Documents.Finance
{
    public class BuildingTaxes
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

    public class DecisionROI
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

    public class Declaration
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

    public class FiscalAttentionCertificate
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

    public class FiscalDecision
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

    public class FiscalDeclaration
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

    public class Invoice
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

    public class LandTaxes
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

    public class RegistrationVATPurpose
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

    public class RUC
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

    public class TrialBalance
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

    public class WHTStatement
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