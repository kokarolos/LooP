using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Entities.Concrete
{
    public class Book : Product
    {
        public int Pages { get; set; }
        public string Author { get; set; }
    }
}
