using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workinterview.Model
{
    public class ApiResponseRoot
    {
        public bool status { get; set; }
        public ResponseInfo data { get; set; }
    }
}
