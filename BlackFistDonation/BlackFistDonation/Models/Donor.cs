using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlackFistDonation.Models
{
    public class Donor
    {
        public int ID { get; set; }

        [Display(Name = "First")]
        public string FirstName { get; set; }

        [Display(Name = "Last")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Display(Name = "Donation Amount")]
        [DataType(DataType.Currency)]
        public int Donation { get; set; }
    }

    public class AzureDBContext : DbContext
    {
        public DbSet<Donor> Donors { get; set; }
    }
}