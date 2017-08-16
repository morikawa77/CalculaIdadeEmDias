using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeAnos, idadeMeses, idadeDias, idadeDiasTotal;
            Console.WriteLine("Digite a quantidade de anos, meses e dias da sua idade: ");
            idadeAnos = Convert.ToInt32(Console.ReadLine());
            idadeMeses = Convert.ToInt32(Console.ReadLine());
            idadeDias = Convert.ToInt32(Console.ReadLine());
            idadeDiasTotal = (idadeAnos * 365) + (idadeMeses * 30) + idadeDias; 
            Console.Write("Sua idade em dias é: " + idadeDiasTotal + " dias.");
            Console.ReadLine();
        }
    }
}
