using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Models
{
   public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role _Role { get; set; }
    }

    public enum Role
    {
        Administrator,
        User,
        Supplier //Fornitore
    }
}

