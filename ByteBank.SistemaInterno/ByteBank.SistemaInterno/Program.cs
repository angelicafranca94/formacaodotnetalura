using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(34534,23423);
            Console.WriteLine(conta.Saldo);

            string nome = "Angelica";

            

            Console.ReadLine();
        }
    }
}
