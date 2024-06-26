using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coolApi.Data;
using coolApi.Interfaces;
using coolApi.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace coolApi.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepo;
        public CommentController(ICommentRepository commentRepo)
        {
            _commentRepo = commentRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _commentRepo.GetAllAsync();

            var CommentDto = comments.Select(s => s.ToCommentDto());

            return Ok(CommentDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var comment = await _commentRepo.GetByIdAsync(id);

            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment.ToCommentDto());
        }
    }
}