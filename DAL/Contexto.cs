using Microsoft.EntityFrameworkCore;
using ParcialAplicada.Models;

namespace ParcialAplicada.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>Options)
            : base (Options) {}

        public DbSet<Libros> Libros {get;set;}
    }
}