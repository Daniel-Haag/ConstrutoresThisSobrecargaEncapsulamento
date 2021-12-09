using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDaConta = 0;
            bool perguntarNovamente = false;
            string titularDaConta = string.Empty;
            double depositoInicial = 0;
            double valorDeposito = 0;
            double valorSaque = 0;

            Console.WriteLine("Sistema de conta bancaria.");
            Console.WriteLine("Informe os 4 dígitos para o número da conta:");
            numeroDaConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do titular da conta:");
            titularDaConta = Console.ReadLine();

            do
            {
                perguntarNovamente = false;
                Console.WriteLine("Haverá depósito inicial ? (s/n)");
                string sn = Console.ReadLine();
                if (sn == "s")
                {
                    Console.WriteLine("Informe o valor do depósito inicial:");
                    depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Conta conta = new Conta(numeroDaConta, titularDaConta, depositoInicial);
                    conta.MostrarDadosDaConta();
                    SolicitarDados(valorDeposito, valorSaque, conta);

                }
                else if (sn == "n")
                {
                    Conta conta = new Conta(numeroDaConta, titularDaConta);
                    conta.MostrarDadosDaConta();
                    SolicitarDados(valorDeposito, valorSaque, conta);
                }
                else
                {
                    Console.WriteLine("Digite uma resposta válida.");
                    perguntarNovamente = true;
                }
            } while (perguntarNovamente);

            Console.Read();
        }

        private static void SolicitarDados(double valorDeposito, double valorSaque, Conta conta)
        {
            Console.WriteLine("Informe um valor para depósito:");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RealizarDeposito(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            conta.MostrarDadosDaConta();
            Console.WriteLine("Informe um valor para saque:");
            valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RealizarSaque(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            conta.MostrarDadosDaConta();
        }
    }
}
