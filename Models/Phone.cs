using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PhoneApplication.Models
{
    public class Phone
    {
        
        public Phone()
        {
            
            PhoneName = "";
            
            DateReleased = DateTime.Now;
        }
        [Key]
            public int PhoneId { get; set; }
        public string PhoneName { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public DateTime DateReleased { get; set; }
        [ForeignKey("Manufacturer")]
        public int ManufactureID { get; set; }
        public int MSRP { get; set; }

    }
    }
