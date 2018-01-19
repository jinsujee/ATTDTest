using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace umayplusapi.Models
{
    public class ResponseMessage
    {
        public int id { get; set; }

        public string status { get; set; }
        public string message { get; set; }
        public Member data { get; set; }
    }
}
