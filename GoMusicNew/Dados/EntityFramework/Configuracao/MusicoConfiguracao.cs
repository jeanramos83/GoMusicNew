using GoMusicNew.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoMusicNew.Dados.EntityFramework.Configuracao
{
    public class MusicoConfiguracao : IEntityTypeConfiguration<Musico>
    {
        public void Configure(EntityTypeBuilder<Musico> builder)
        {
            builder.ToTable("GoMusic_Musico", "dbo");

            builder.HasKey("IdMusico");

            builder.Property(t => t.IdMusico).HasColumnName("IdMusico").HasColumnType("int");
            builder.Property(t => t.Instrumentos).HasColumnName("Instrumentos").HasColumnType("varchar(50)").IsRequired();
            builder.Property(t => t.DescricaoMusico).HasColumnName("DescricaoMusico").HasColumnType("varchar(100)").IsRequired();
            builder.Property(t => t.GeneroMusical).HasColumnName("GeneroMusical").HasColumnType("varchar(50)").IsRequired();
            builder.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(t => t.CPF).HasColumnName("CPF").HasColumnType("varchar(11)").IsRequired();
            builder.Property(t => t.Idade).HasColumnName("Idade").HasColumnType("int").IsRequired().IsRequired();
            builder.Property(t => t.Telefone).HasColumnName("Telefone").HasColumnType("varchar(15)").IsRequired();
            builder.Property(t => t.Email).HasColumnName("Email").HasColumnType("varchar(50)").IsRequired();         
            builder.Property(t => t.IdEndereco).HasColumnName("IdEndereco").HasColumnType("int");
           
        }
    }
}
