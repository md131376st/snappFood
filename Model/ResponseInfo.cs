using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workinterview.Model
{
    public class ResponseInfo
    {
        public int count { get; set; }
        public IList<FinalResult> finalResult { get; set; }
    }
}
