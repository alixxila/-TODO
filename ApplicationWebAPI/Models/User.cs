
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationWebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsBlocked { get; set; }
    }
}
