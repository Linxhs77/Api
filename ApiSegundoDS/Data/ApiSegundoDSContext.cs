using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiSegundoDS.Models;

namespace ApiSegundoDS.Data
{
    public class ApiSegundoDSContext : DbContext
    {
        public ApiSegundoDSContext (DbContextOptions<ApiSegundoDSContext> options)
            : base(options)
        {
        }

        public DbSet<ApiSegundoDS.Models.Aluno> Aluno { get; set; } = default!;
        public DbSet<ApiSegundoDS.Models.Professor> Professor { get; set; } = default!;
        public DbSet<ApiSegundoDS.Models.Escola> Escola { get; set; } = default!;
    }
}
