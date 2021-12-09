using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        public int NumeroDaConta { get; private set; }
        public string TitularDaConta { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            Saldo = 0;
        }

        public Conta(int numeroDaConta, string titularDaConta, double saldo) : this(numeroDaConta, titularDaConta)
        {
            Saldo = saldo;
        }

        public void RealizarDeposito(double valor)
        {
            Saldo += valor;
        }

        public void RealizarSaque(double valor)
        {
            Saldo -= valor + 5;
        }

        public void MostrarDadosDaConta()
        {
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta: {NumeroDaConta}, Titular: {TitularDaConta}, Saldo: $ {Saldo.ToString("F2")}");
        }
    }
}
