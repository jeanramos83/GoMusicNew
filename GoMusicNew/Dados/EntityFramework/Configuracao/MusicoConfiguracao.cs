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
            builder.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(t => t.CPF).HasColumnName("CPF").HasColumnType("varchar(11)").IsRequired();
            builder.Property(t => t.Instrumentos).HasColumnName("Instrumentos").HasColumnType("varchar(50)").IsRequired();
        }
    }
}
