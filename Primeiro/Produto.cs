using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Primeiro
{
    class Produto
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return $"Código: {Codigo} - Descrição: {Descricao}";
        }
    }
}
