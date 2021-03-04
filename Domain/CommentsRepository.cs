using AutoMapper;
using BlogService.Contexts;
using BlogService.DTO;
using BlogService.Interfaces;
using BlogService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogService.Domain
{
    public class CommentsRepository: IComments
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CommentsRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<CommentsDTO> saveComments(CommentsDTO comments)
        {
            try
            {
                comments.Id = Guid.NewGuid();
                var comment = mapper.Map<Comments>(comments);
                context.Add(comment);
                await context.SaveChangesAsync();
                return mapper.Map<CommentsDTO>(comment);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CommentsDomain", ex);
            }
        }
    }
}
