using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SweetAndSavory.Models
{
    public class Treat
    {
        public Treat()
        {
            this.JoinEntries = new HashSet<TreatFlavor>();
        }
        public int TreatId { get; set; }

        [DisplayName("Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }

        [DisplayName("Treat Name")]
        public string TreatName { get; set; }
        
        public virtual ICollection<TreatFlavor> JoinEntries { get; set; }
    }
}

