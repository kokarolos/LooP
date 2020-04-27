using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Entities.Concrete
{
    public class Attachment
    {

        public int AttachmentId { get; set; }
        public string Path { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }

    }
}
