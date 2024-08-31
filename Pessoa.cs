using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Sarigue
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
    }
}
