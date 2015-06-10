using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel.Users
{
    class user
    {
        public Guid IDUser { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Mobile { get; set; }
        public string Birthdate { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public virtual Roles.role roles { get; set; }
    }
}
