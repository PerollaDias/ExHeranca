using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Exercicio3
{
    internal class Conta
    {
        private string agencia1;

        public int numeroconta { get; set; }
        public int agencia { get; set; }
        public string titularconta { get; set; }
        public double saldoconta { get; set; }

        public Conta()
        {
        }

        public Conta(int numeroconta, string agencia1, string titularconta, double saldoconta)
        {
            this.numeroconta = numeroconta;
            this.agencia1 = agencia1;
            this.titularconta = titularconta;
            this.saldoconta = saldoconta;
        }

        public virtual void Saque(double valor)
        {
            if(valor <= saldoconta)
            {
                saldoconta -= valor;
                Console.WriteLine(" Saque realizado com sucesso!!! ");
            }
            else
            {
                Console.WriteLine(" Saldo insuficiente para o saque!!! ");
            }
            
        }
        public virtual void RealizEmprestimo(double valor)
        {
            saldoconta += valor;
            Console.WriteLine(" Depósito realizado com sucesso!!! ");
        }
    }
}
