using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Sarigue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Danilo", "Couto");
            Pessoa pessoa2 = new Pessoa("Maria", "Silva");

            // Criação de uma instância de Suite
            Suite suite = new Suite("Luxo", 2, 150.00m);

            // Criação de uma instância de Reserva
            Reserva reserva = new Reserva(11);

            // Cadastrando a suite escolhida na reserva
            reserva.CadastrarSuite(suite);

            // Cadastrando hóspedes na reserva
            reserva.CadastrarHospedes(new List<Pessoa> { pessoa1, pessoa2 });

            // Obter a quantidade de hóspedes
            reserva.ObterQuantidadeHospedes();

            // Calcular o valor total da estadia
            reserva.CalcularValorEstadia();
        }
    }
}
