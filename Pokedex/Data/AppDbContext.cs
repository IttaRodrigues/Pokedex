using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data;

public class AppDbContext: DbContext
{
     public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
     {
        
     }   

     public DbSet<Genero> Generos { get; set; }
     public DbSet<Pokemon> Pokemons { get; set; }
     public DbSet<PokemonTipo>  PokemonTipos { get; set; }
    public DbSet<Regiao> Regiaos { get; set; }
    public DbSet<Tipo> Tipos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region Configuração de Muitos para Muitos - PokemonTipo
        //Definindo chave primária
        modelBuilder.Entity<PokemonTipo>()
            .HasKey(pt => new { pt.PokemonNumero, pt.TipoId });




        #endregion
    }
}


