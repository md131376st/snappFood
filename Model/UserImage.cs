using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workinterview.Model
{
    public class UserImage
    {
        public int id { get; set; }
        public string description { get; set; }
        public string fileName { get; set; }
        public string thumbNailSource { get; set; }
        public int likeCount { get; set; }
        public int commentCount { get; set; }
        public int timeDifference { get; set; }
        public string imageType { get; set; }
        public string userType { get; set; }
    }
}
