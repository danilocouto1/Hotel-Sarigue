using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Sarigue
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public List<Pessoa> Hospedes;
        public Suite Suite;
        public int DiasReservados;

        public void CadastrarHospedes(List<Pessoa> hospedes) {
            Hospedes.AddRange(hospedes);
            Console.WriteLine("Hospedes cadastrados");
            foreach (var item in Hospedes)
            {
                Console.WriteLine($"{item.Nome} {item.Sobrenome} cadastrado!");
            }
        }
        public void CadastrarSuite(Suite suite) {
            Suite = suite;
            Console.WriteLine($"Suite tipo {Suite.TipoSuite} cadastrado!");
        }
        public int ObterQuantidadeHospedes() {
            if (Hospedes == null)
            {
                return 0;
            }
            Console.WriteLine(Hospedes.Count);
            return Hospedes.Count;
        }
        public decimal CalcularValorEstadia() {
            if (Hospedes == null)
            {
                return 0;
            }
            Console.WriteLine(DiasReservados * Suite.ValorDiaria);
            return DiasReservados * Suite.ValorDiaria;
        }
    }
}
