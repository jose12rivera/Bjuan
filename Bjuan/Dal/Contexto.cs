using Bjuan.Models;
using Microsoft.EntityFrameworkCore;

namespace Bjuan.Dal
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto>options)
        :base(options){ }

        public DbSet<Articulos> Articulos { get; set; }
    }
}
