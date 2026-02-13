using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{  
    public class Equipment
    {    
        [Key]
        public int SerialNumber { get; set; }
        [Required]  
        public string Model { get; set; }
        [Required]  
        public string Category { get; set; }
        public LoanStatus status { get; set; }
    }
}
