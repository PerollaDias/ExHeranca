using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Exercicio3
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string CPF { get; set; }
        public string NomeInst { get; set; }

        public ContaEstudante(double limiteChequeEspecial, string CPF, string nomeInst, int numeroconta, int Agencia, 
            string titularconta, double saldoconta)
           : base(numeroconta, Agencia, titularconta, saldoconta)
        {
        }



        public override void Saque(double Valor)
        {
            if (Valor <= Saldoconta + LimiteChequeEspecial)
            {
                Saldoconta -= Valor;
                Console.WriteLine($" Saque realizado no valor de: {Valor} reais! ");

            }
            else
            {
                Console.WriteLine("saldo insuficiente.");
                
            }
        }
    }
       
}

