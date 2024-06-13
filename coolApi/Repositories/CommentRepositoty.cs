using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coolApi.Data;
using coolApi.Interfaces;
using coolApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coolApi.Repositories
{
    public class CommentRepositoty : ICommentRepository
    {
        private readonly ApplicationDBContext _context; //
        public CommentRepositoty(ApplicationDBContext context)
        {
            _context = context;
        }

        public Task<Comment> CreateAsync(Comment commentModel)
        {
            throw new NotImplementedException();
        }

        public Task<Comment?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        
        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

        public Task<Comment?> UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}