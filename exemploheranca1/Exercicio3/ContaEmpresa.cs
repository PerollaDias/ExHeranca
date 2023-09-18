using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Exercicio3
{
    internal class ContaEmpresa:Conta
    {
        public ContaEmpresa(double taxaanuidade, double limiteemprestimo, double totalemprestimo, int numeroconta, int agencia, string titularconta, double saldoconta) 
            : base(numeroconta, agencia, titularconta, saldoconta)
        {
        }

        public double Taxaanuidade { get; set; }
        public double Limiteemprestimo { get; set; }
        public double Totalemprestimo { get; set; }

       

        public override void Saque(double valor)
        {
            if (valor <= 5000)
            {
                base.Saque(valor);

            }
            else
            {
                if(valor + 5 <= Saldoconta)
                {
                    Saldoconta -= (valor + 5);
                    Console.WriteLine($" Saque de {valor} reais realizado com taxa de R$5,00");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
        }
        
        public virtual void RealizEmprestimo(double valor)
        {
            
            
            if (valor <= Limiteemprestimo - Totalemprestimo)
            {
                Saldoconta += valor;
                Totalemprestimo += valor;
                Console.WriteLine($" Empréstimo no valor: {valor} realizado com sucesso!!! ");
            }
            else
            {
                Console.WriteLine(" Limite excedido!!! ");
            }
            
        }

    }
}
