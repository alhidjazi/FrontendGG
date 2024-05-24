using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coolApi.Models;
using Microsoft.EntityFrameworkCore;

namespace coolApi.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Stock> Stocks {get; set;}
        public DbSet<Comment> Comments {get; set;}
    }
}