using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Conta
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Numero { get; set; }

        public string Agencia { get; set; }

        protected decimal Saldo { get; set; }

        public DateTime DataDeAbertura { get; set; }
    

    public decimal GetSaldo();
    {
        return Saldo;
    }
}

    public void Deposita(decimal valorDoDeposito)
    {
        Saldo += valorDoDeposito;
    }
}
