using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coolApi.Dtos.Comment
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;
        public DateTime CreateOn {get; set;} = DateTime.Now;

        //ilişkili propertys
        public int? StockId { get; set; }
    }
}