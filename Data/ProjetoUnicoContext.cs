using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoUnico.Models;

namespace ProjetoUnico.Data
{
    public class ProjetoUnicoContext : DbContext
    {
        public ProjetoUnicoContext (DbContextOptions<ProjetoUnicoContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoUnico.Models.Movie> Movie { get; set; } = default!;
    }
}
