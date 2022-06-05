using System;
using System.ComponentModel.DataAnnotations;

namespace myScriptureJournal.Models
{
    public class Scripture
    {
        public int ID {get; set;}
        [Required]
        public string Book { get; set; }
        [Required]
        public string Reference { get; set; }
        public string Notes { get; set; }
        
        [Display(Name = "Added Date")]
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }

    }
}
