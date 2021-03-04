using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogService.Models
{
    public class ResponseLogin
    {
        public string User { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
