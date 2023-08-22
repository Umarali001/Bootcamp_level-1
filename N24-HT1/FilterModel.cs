using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1
{
    internal abstract class FilterModel
    {
        public int PageSize { get; set; }
        public int PageTocen { get; set; }

        //public FilterModel(int pageSize, int pageTocen)
        //{
        //    PageSize = pageSize;
        //    PageTocen = pageTocen;
        //}
    }



    class UserFilterModel : FilterModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; 



    }
}
