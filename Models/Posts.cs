using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogService.Models
{
    public class Posts
    {
        public Guid Id { get; set; }
        public string PostDescription { get; set; }
        public string AuthorName { get; set; }
        public DateTime SubmitDate { get; set; }
        public int State { get; set; }
    }
}
