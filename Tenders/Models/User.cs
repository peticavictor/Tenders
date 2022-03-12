using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Tenders.Models
{
    enum UserType
    {
        Seller,
        Buyer
    }
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Type { get; set; }
    }
}
