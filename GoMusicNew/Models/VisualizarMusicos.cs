using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoMusicNew.Models
{
    public class VisualizarMusicos
    {
        public int IdVisualizacao { get; set; }
        public string DescEspecialidade { get; set; }
        public string NomeMusico { get; set; }
        public string Cidade { get; set; }
        public string GeneroMusical { get; set; }
        public int IdCadastro { get; set; }
        public virtual Cadastro Cadastro { get; set; }
    }
}
