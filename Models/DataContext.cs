using System.Data.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PhoneApplication.Models
{
    public class DataContext: DbContext

    {
        	public DbSet<Phone> Phone { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

    }
}