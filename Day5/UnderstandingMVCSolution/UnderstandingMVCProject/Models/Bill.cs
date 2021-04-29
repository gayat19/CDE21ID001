using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingMVCProject.Models
{
    public class Bill
    {
        [Key]
        public int BillNumber { get; set; }
        public float Amount { get; set; }
      
        public int CustomerId { get; set; }
        

    }
}
