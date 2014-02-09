using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlackFistDonation.Models
{
    public class Donor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Donation { get; set; }
    }

    public class DonorDBContext : DbContext
    {
        public DbSet<Donor> Donors { get; set; }
    }
}