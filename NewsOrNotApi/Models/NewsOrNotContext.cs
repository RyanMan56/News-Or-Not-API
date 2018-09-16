using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsOrNotApi.Models
{
    public class NewsOrNotContext : DbContext
    {
        public NewsOrNotContext(DbContextOptions<NewsOrNotContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
