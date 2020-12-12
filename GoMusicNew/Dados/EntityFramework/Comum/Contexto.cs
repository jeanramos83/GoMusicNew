using GoMusicNew.Dados.EntityFramework.Configuracao;
using GoMusicNew.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoMusicNew.Dados.EntityFramework.Comum
{
    public class Contexto : DbContext
    {
        public DbSet<Musico> Musico { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MusicoConfiguracao());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguracao());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"
                Data source = 201.62.57.93;
                database = dbPICC_20202;
                user id = laboratorio;
                password = @laboratorio*;"
            );
        }
    }
}
