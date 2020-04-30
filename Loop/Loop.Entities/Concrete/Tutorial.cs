using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Entities.Concrete
{
    public class Tutorial : Product
    {
        public int Duration { get; set; }
        public string Subject { get; set; }

        public virtual VideoFile  VideoFile { get; set; }
    }
}
