using BlogService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogService.DTO
{
    public class PostDTO
    {
        public Guid Id { get; set; }
        public string PostDescription { get; set; }
        public string AuthorName { get; set; }
        public DateTime SubmitDate { get; set; }
        public int State { get; set; }
    }
}
