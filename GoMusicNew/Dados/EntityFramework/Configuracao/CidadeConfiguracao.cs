using GoMusicNew.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoMusicNew.Dados.EntityFramework.Configuracao
{
    public class CidadeConfiguracao : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("GoMusic_Cidade", "dbo");

            builder.HasKey("IdCidade");
            builder.Property(t => t.IdCidade).HasColumnName("IdCidade").HasColumnType("int").IsRequired();
            builder.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("varchar(20)").IsRequired();
            builder.Property(t => t.UF).HasColumnName("UF").HasColumnType("char(2)").IsRequired();
        }
    }
}
