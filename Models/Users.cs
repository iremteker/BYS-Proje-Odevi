using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BYSDeneme.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public int? RelatedID { get; set; }
        public string Email { get; set; }
    }
}