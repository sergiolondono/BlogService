using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlogService.Contexts;
using BlogService.Domain;
using BlogService.DTO;
using BlogService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BlogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPosts _postsDomain;

        /// <summary>
        /// Constructor controller
        /// </summary>
        /// <param name="context">ApplicationDbContext of application</param>
        /// <param name="mapper">Interface to map over DTO's</param>
        /// <returns></returns>
        public PostsController(ApplicationDbContext context, IMapper mapper)
        {
            _postsDomain = new PostRepository(context, mapper);
        }

        /// <summary>
        /// Method to get posts
        /// </summary>
        /// <param name="rol">Param to filter the results</param>
        /// <returns>Return IEnumerable of PostDTO</returns>
        [HttpGet("{rol}")]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetPosts(string rol)
        {
            var response = await _postsDomain.GetPosts(rol);
            return Ok(response);
        }

        /// <summary>
        /// Method to get pubilshed posts
        /// </summary>
        /// <param name="rol">Param to filter the results</param>
        /// <returns>Return IEnumerable of PostDTO</returns>
        [HttpGet("/api/posts/published/{rol}")]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetPostsPublished(string rol)
        {
            var response = await _postsDomain.GetPosts(rol);
            return Ok(response);
        }

        /// <summary>
        /// Method to save posts
        /// </summary>
        /// <param name="post">Param of type PostDTO</param>
        /// <returns>Return IEnumerable of PostDTO saved</returns>
        [HttpPost]
        public async Task<ActionResult<PostDTO>> savePosts(PostDTO post)
        {
            if (post == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(post.PostDescription))
            {
                return Problem(statusCode: 422, title: "Invalid data, PostDescription property cannot be empty!");
            }

            if (string.IsNullOrEmpty(post.State.ToString()))
            {
                return Problem(statusCode: 422, title: "Invalid data, State property cannot be empty!");
            }

            if (string.IsNullOrEmpty(post.AuthorName.ToString()))
            {
                return Problem(statusCode: 422, title: "Invalid data, AuthorName property cannot be empty!");
            }

            var response = await _postsDomain.savePost(post);
            return Ok(response);
        }

        /// <summary>
        /// Method to update posts
        /// </summary>
        /// <param name="id">idPost of Post to update</param>
        /// <param name="post">Param of type PostDTO</param>
        /// <returns>Return IEnumerable of PostDTO updated</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<PostDTO>> updatePosts(string id, [FromBody] PostDTO post)
        {
            if (post == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrEmpty(id))
            {
                return Problem(statusCode: 422, title: "Invalid data, Id property cannot be empty!");
            }

            var response = await _postsDomain.updatePost(id, post);
            return Ok(response);
        }

        /// <summary>
        /// Method to update post state
        /// </summary>
        /// <param name="id">idPost of Post to update</param>
        /// <param name="state">state of Post to update(1 = PendingToApproval, 2 = Reject, 3 = Approval)</param>
        /// <returns>Return IEnumerable of PostDTO updated</returns>
        [HttpPut("{id}/{state}")]
        public async Task<ActionResult<PostDTO>> updatStatePosts(string id, int state)
        {
            if (string.IsNullOrEmpty(id))
            {
                return Problem(statusCode: 422, title: "Invalid data, Id property cannot be empty!");
            }

            await _postsDomain.updateState(id, state);
            return Ok();
        }

        /// <summary>
        /// Method to delete a post
        /// </summary>
        /// <param name="id">idPost of Post to delete</param>
        /// <returns>Return NoContent IActionResult</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> deletePosts(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return Problem(statusCode: 422, title: "Invalid data, Id property cannot be empty!");
            }

            await _postsDomain.deletePost(id);
            return NoContent();
        }

    }
}