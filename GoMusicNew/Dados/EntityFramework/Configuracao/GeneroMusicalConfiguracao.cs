using GoMusicNew.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoMusicNew.Dados.EntityFramework.Configuracao
{
    public class GeneroMusicalConfiguracao : IEntityTypeConfiguration<GeneroMusical>
    {
        public void Configure(EntityTypeBuilder<GeneroMusical> builder)
        {
            builder.ToTable("GoMusic_GeneroMusical", "dbo");

            builder.HasKey("IdGenero");
            builder.Property(t => t.IdGenero).HasColumnName("IdGenero").HasColumnType("int").IsRequired();
            builder.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("varchar(20)").IsRequired();
        }
    }
}
