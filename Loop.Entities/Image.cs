using Loop.Entities.Concrete;
using System.Collections;
using System.Collections.Generic;

namespace Loop.Entities
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImgName { get; set; }
        public string ImgPath { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }

        //public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
