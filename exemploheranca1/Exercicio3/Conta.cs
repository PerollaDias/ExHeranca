using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Exercicio3
{
    internal class Conta
    {

        public int Numeroconta { get; set; }
        public int Agencia { get; set; }
        public string Titularconta { get; set; }
        public double Saldoconta { get; set; }

        public Conta()
        {
        }

        public Conta(int numeroconta, int agencia, string titularconta, double saldoconta)
        {
            this.Numeroconta = numeroconta;
            this.Agencia = agencia;
            this.Titularconta = titularconta;
            this.Saldoconta = saldoconta;
        }

        public virtual void Saque(double Valor)
        {
            if(Valor <= Saldoconta)
            {
                Saldoconta -= Valor;
                Console.WriteLine(" Saque realizado com sucesso!!! ");
            }
            else
            {
                Console.WriteLine(" Saldo insuficiente para o saque!!! ");
            }
            
        }
        public virtual void Depositar(double Valor)
        {

            Saldoconta += Valor;
            Console.WriteLine(" Depósito na sua conta realizado com sucesso!!! ");
        }
    }
}
