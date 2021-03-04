using BlogService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogService.Interfaces
{
    public interface IComments
    {
        Task<CommentsDTO> saveComments(CommentsDTO comments);
    }
}
