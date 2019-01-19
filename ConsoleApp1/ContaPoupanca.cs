using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(string nome, string cpf, string agencia, string numero) // necessário informar o tipo 
        {
            Nome = nome;   // atribuir valores ao atributos
            CPF = cpf;
            Agencia = agencia;
            Numero = numero;
        }

        public void Saca(decimal valorDoSaque)
        {
            if (Saldo > valorDoSaque)
            {
                Saldo -= valorDoSaque;
            }
        }
    }
}
