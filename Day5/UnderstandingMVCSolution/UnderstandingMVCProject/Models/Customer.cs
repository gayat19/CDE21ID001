using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingMVCProject.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
