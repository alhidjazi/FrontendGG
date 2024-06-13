using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coolApi.Models;

namespace coolApi.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id);
        Task<Comment?> DeleteAsync(int id);
    }
}