using Filmes.EntityFramework.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Filmes.EntityFramework.Dados
{
    public class FilmesContexto : DbContext
    {
        public DbSet<Ator> Atores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraFilmes;Trusted_connection=true;");
        }
    }
}
