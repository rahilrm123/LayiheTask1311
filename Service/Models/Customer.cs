using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Models
{
    public class Customer :BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
