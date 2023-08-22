using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1
{
    internal interface IUserServise
    {
        List<User> Get(int PageSize, int PageToken);
        List<User> Filter(UserFilterModel filter);
        void Add(string Name, string LastName, string EmailAddres);
    }



    public class UserServise : IUserServise
    {

        List<User> users = new List<User>();

        public List<User> Get(int PageSize, int PageToken)
        {

        }

        public List<User> Filter(UserFilterModel filter)
        {

        }


        public void Update(User User)
        {
            
        }


        public bool Delete(Id)
        {

        }




       public void Add(string Name, string LastName, string EmailAddres)
        {

        }
    }
}


