using BlogService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogService.Interfaces
{
    public interface IPosts
    {
        Task<IEnumerable<PostDTO>> GetPosts(string rol);

        Task<PostDTO> savePost(PostDTO post);

        Task<PostDTO> updatePost(string id, PostDTO post);

        Task<bool> updateState(string id, int state);

        Task<bool> deletePost(string id);
    }
}
