using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAddres { get; set; }
        public bool IsDeleted { get; set; }


        public User(string name, string emailaddres)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = name;
            EmailAddres = emailaddres;
            IsDeleted = false;
        }
    }
}
