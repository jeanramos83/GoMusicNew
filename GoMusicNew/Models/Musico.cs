using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace GoMusicNew.Models
{
    public class Musico
    {
        public int IdMusico { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }
        public Endereco Endereco { get; set; }
        public string Instrumentos { get; set; }
        public string DescricaoMusico { get; set; }
        public string GeneroMusical { get; set; }
    }
}
