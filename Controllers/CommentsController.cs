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
using Microsoft.AspNetCore.Mvc;

namespace BlogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IComments _commentsDomain;
        public CommentsController(ApplicationDbContext context, IMapper mapper)
        {
            _commentsDomain = new CommentsRepository(context, mapper);
        }

        /// <summary>
        /// Method to save comments
        /// </summary>
        /// <param name="comments">CommentsDTO entity</param>
        /// <returns>Return object of type CommentsDTO</returns>
        [HttpPost]
        public async Task<ActionResult> saveComments([FromBody] CommentsDTO comments)
        {
            if (comments == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(comments.Comment))
            {
                return Problem(statusCode:422, title: "Invalida data, Comment property cannot be empty!");
            }

            if (string.IsNullOrEmpty(comments.PostId.ToString()))
            {
                return Problem(statusCode: 422, title: "Invalida data, PostId property cannot be empty!");
            }

            return Ok(await _commentsDomain.saveComments(comments));
        }
    }
}