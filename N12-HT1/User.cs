using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N12_HT1
{
    internal class User
    {
        public string name;
        public string lastname;
        public string middlename;
        public string fullname;


        public string Name { get => Name; set => fullname = $"{Name} {LastName} {MiddleName}"; }
        public string LastName { get => LastName; set => lastname = $"{Name} {LastName} {MiddleName}"; }
        public string MiddleName { get => MiddleName; set => middlename = $"{Name} {LastName} {MiddleName}"; }
        public string FullName
        {
            get => $"{Name} {LastName} {MiddleName}";
        }
    }
}
