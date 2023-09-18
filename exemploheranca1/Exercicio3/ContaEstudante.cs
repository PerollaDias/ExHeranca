using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Exercicio3
{
    internal class ContaEstudante:Conta
    {
        public double limiteChequeEspecial { get; set; }
        public string CPF { get; set; }
        public string nomeInst { get; set; }

        public ContaEstudante(double limiteChequeEspecial, string CPF, string nomeInst, int numeroconta, string Agencia, string titularconta, double saldoconta)
           : base(numeroconta, Agencia, titularconta, saldoconta)
        {
        }



        public override void Saque(double Valor)
        {
            if (Valor <= limiteChequeEspecial)
            {
                base.Saque(Valor);

            }
            else
            {
                if (Valor + 5 <= Saldoconta)
                {
                    Saldoconta -= (Valor + 5);
                    Console.WriteLine($" Saque realizado com taxa de R$5,00");
                }
                else
                {
                    Console.WriteLine("saldo insuficiente.");
                }
            }
        }
    }
       
}

