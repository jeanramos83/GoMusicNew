using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoMusicNew.Models
{
    public class Cadastro
    {
        public int IdCadastro { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string DescricaoMusico { get; set; }
        public string GeneroMusical { get; set; }
        public string Especialidade { get; set; }
        public int IdMusico { get; set; }
        public virtual Musico Musico { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public int IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
