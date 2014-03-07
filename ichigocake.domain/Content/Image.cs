using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;

namespace ichigocake.domain.Content
{
    public enum ImageType
    {
        UserImage = 1,
        CakeImage = 2,
        BigImage = 3,
        SmallImage = 4
    }
    public class Image : AuditEntity
    {
        public string Description { get; set; }
        public string Url { get; set; }
        public ImageType Type { get; set; }
    }
}
