using AutoMapper;
using BlogService.Contexts;
using BlogService.DTO;
using BlogService.Interfaces;
using BlogService.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogService.Domain
{
    public class PostRepository: IPosts
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private const string writer = "writer";
        private const string editor = "editor";
        private const string nonAuthenticated = "non";
        private const string all = "all";

        public PostRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<PostDTO>> GetPosts(string rol)
        {
            var postsDTO = new List<PostDTO>();
            var posts = await context
                         .Posts
                         .ToListAsync();
            if (rol == all)
            {
                postsDTO = mapper.Map<List<PostDTO>>(posts);
            }
            else if (rol == writer)
            {
                var postsFiltered = posts
                .Where(p => p.State == 2 || p.State == 1);
                postsDTO = mapper.Map<List<PostDTO>>(postsFiltered);
            }
            else if (rol == editor)
            {
                var postsFiltered = posts
               .Where(p => p.State == 1);
                postsDTO = mapper.Map<List<PostDTO>>(postsFiltered);
            }
            else if (rol == nonAuthenticated)
            {
               var postsFiltered = posts
              .Where(p => p.State == 3);
               postsDTO = mapper.Map<List<PostDTO>>(postsFiltered);
            }
                return postsDTO;
        }

        public async Task<PostDTO> savePost(PostDTO post)
        {
            try
            {
                post.Id = Guid.NewGuid();
                post.SubmitDate = DateTime.Now;
                var postDB = mapper.Map<Posts>(post);
                context.Add(postDB);
                await context.SaveChangesAsync();
                return mapper.Map<PostDTO>(postDB);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en PostsDomain", ex);
            }
        }

        public async Task<PostDTO> updatePost(string id, PostDTO post)
        {
            var postDB = mapper.Map<Posts>(post);
            postDB.Id = Guid.Parse(id);
            context.Entry(postDB).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return mapper.Map<PostDTO>(postDB);
        }

        public async Task<bool> updateState(string id, int state)
        {
            var post = new Posts() { Id = Guid.Parse(id), State = state };
            using (var db = context)
            {
                db.Posts.Attach(post);
                db.Entry(post).Property(x => x.State).IsModified = true;
                db.SaveChanges();
                return true;
            }
        }

        public async Task<bool> deletePost(string id)
        {
            var postId = await context.Posts.Select(x => x.Id).FirstOrDefaultAsync(x => x == Guid.Parse(id));
            context.Remove(new Posts { Id = postId });
            await context.SaveChangesAsync();
            return true;
        }

    }
}
