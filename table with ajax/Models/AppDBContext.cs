using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace table_with_ajax.Models
{
    public class AppDBContext: DbContext
    {
        private readonly DbContextOptions _options;

        public AppDBContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        public DbSet<User> users { get; set; }
    }
}
