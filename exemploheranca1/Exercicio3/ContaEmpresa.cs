using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Exercicio3
{
    internal class ContaEmpresa:Conta
    {
        public ContaEmpresa(double taxaanuidade, double limiteemprestimo, double totalemprestimo, int numeroconta, string agencia, string titularconta, double saldoconta) 
            : base(numeroconta, agencia, titularconta, saldoconta)
        {
        }

        public double taxaanuidade { get; set; }
        public double limiteemprestimo { get; set; }
        public double totalemprestimo { get; set; }

       

        public override void Saque(double valor)
        {
            if (valor <= 5000)
            {
                base.Saque(valor);

            }
            else
            {
                if(valor + 5 <= saldoconta)
                {
                    saldoconta -= (valor + 5);
                    Console.WriteLine($" Saque realizado com taxa de R$5,00");
                }
                else
                {
                    Console.WriteLine("saldo insuficiente.");
                }
            }
        }
        
        public virtual void RealizEmprestimo(double valor)
        {
            
            
            if (valor <= limiteemprestimo)
            {
                saldoconta += valor;
                totalemprestimo += valor;
                Console.WriteLine($" Empréstimo no valor: {valor} realizado com sucesso!!! ");
            }
            else
            {
                Console.WriteLine(" Limite excedido!!! ");
            }
            
        }

    }
}
