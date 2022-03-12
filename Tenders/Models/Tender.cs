using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tenders.Models
{
    public class Tender
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description{ get; set; }
        public double StartPrice { get; set; }
        public double FinalPrice { get; set; }
        public DateTime CreationDate{ get; set; }
        public int CreatedBy{ get; set; }
        public String CPVCode { get; set; }
        public int Status { get; set; }
    }
}
