using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Exam.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public int QuoteID { get; set; }  //Primary key
        [Required(ErrorMessage = "Enter a quote")]
        public string QuoteMessage { get; set; }
        [Required(ErrorMessage = "Enter the author")]
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }
    }
}
