using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginPageAspNetCorEF_SQL.Models;

namespace LoginPageAspNetCorEF_SQL.Data
{
    public class LoginPageAspNetCorEF_SQLContext : DbContext
    {
        public LoginPageAspNetCorEF_SQLContext (DbContextOptions<LoginPageAspNetCorEF_SQLContext> options)
            : base(options)
        {
        }

        public DbSet<LoginPageAspNetCorEF_SQL.Models.Item> Item { get; set; }
    }
}
