using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiDaora.Models;

namespace ApiDaora.Data
{
    public class DBcbrContext : DbContext
    {
        public DBcbrContext (DbContextOptions<DBcbrContext> options)
            : base(options)
        {
        }

        public DbSet<ApiDaora.Models.Carros> Carros { get; set; } = default!;
    }
}
