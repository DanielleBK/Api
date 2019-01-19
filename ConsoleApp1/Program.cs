using PrimeiroProjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente("Ana Carolina", "12312312300", "12345", "1234567", 100); //(Primeiro obj)
            Console.WriteLine("O nome do cliente é " + contaCorrente.Nome + ".");
            contaCorrente.Deposita(50);
            Console.WriteLine("O Saldo da conta corrente é  R$" + contaCorrente.GetSaldo + ".");
            Console.WriteLine("Informe o valor que desela sacar: ");
            decimal valorASacar = decimal.Parse(Console.ReadLine());
            contaCorrente.Saca(valorASacar);
            Console.WriteLine("O Saldo da conta corrente é  R$" + contaCorrente.GetSaldo + ".");
            Console.ReadKey(); ////Para executar e não fechar a pagina
        }
    }
}
