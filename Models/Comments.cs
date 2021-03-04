using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogService.Models
{
    public class Comments
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public string Comment { get; set; }
    }
}
