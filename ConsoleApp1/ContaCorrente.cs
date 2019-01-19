using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class ContaCorrente : Conta
    {
        private decimal LimiteDeChequeEspecial { get; set; }

        //constructor
        public ContaCorrente(string nome, string cpf, string agencia, string numero, decimal limite) // necessário informar o tipo 
        {
            Nome = nome;   // atribuir valores ao atributos
            CPF = cpf;
            Agencia = agencia;
            Numero = numero;
            LimiteDeChequeEspecial = limite;
        }
        //metodos
        public void Saca(decimal valorDoSaque)
        {
            if ((Saldo + LimiteDeChequeEspecial) >= valorDoSaque)
            {
                Saldo -= valorDoSaque;
            }
        }
    }
}


