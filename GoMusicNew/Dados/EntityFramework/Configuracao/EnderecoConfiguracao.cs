using GoMusicNew.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoMusicNew.Dados.EntityFramework.Configuracao
{
    public class EnderecoConfiguracao : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("GoMusic_Endereco", "dbo");

            builder.HasKey("IdEndereco");
            builder.Property(t => t.IdEndereco).HasColumnName("IdEndereco").HasColumnType("int").IsRequired();
            builder.Property(t => t.Rua).HasColumnName("Rua").HasColumnType("varchar(50)").IsRequired();
            builder.Property(t => t.Cidade).HasColumnName("Cidade").HasColumnType("varchar(20)").IsRequired();
            builder.Property(t => t.Numero).HasColumnName("Numero").HasColumnType("varchar(6)").IsRequired();
            builder.Property(t => t.Bairro).HasColumnName("Bairro").HasColumnType("varchar(30)").IsRequired();
            builder.Property(t => t.UF).HasColumnName("UF").HasColumnType("char(2)").IsRequired();
            builder.Property(t => t.IdMusico).HasColumnName("IdMusico").HasColumnType("int");
        }
    }
}
