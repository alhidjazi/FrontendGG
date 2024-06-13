using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coolApi.Dtos.Comment;
using coolApi.Models;

namespace coolApi.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel){
            return new CommentDto{
                Id = commentModel.Id,
                Title = commentModel.Content,
                Content = commentModel.Content,
                CreateOn = commentModel.CreateOn,
                StockId = commentModel.StockId
            };
        }
    }
}