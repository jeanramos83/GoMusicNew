﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoMusicNew.Models
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
    }
}
