using exemploheranca1.Classes;
using exemploheranca1.Exercicio2;
using exemploheranca1.Exercicio3;
public class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta();
        {
            conta.Numeroconta = 100;
            conta.Agencia = 01;
            conta.Titularconta = "Pérolla";
            conta.Saldoconta = 1000;
        }

        Console.WriteLine("Conta Empresa");
        Console.WriteLine($"Saldo atual: {conta.Saldoconta}\n");
        Console.WriteLine("Menu:\n" +
            "Opção 1: sacar. \n" +
            "Opção 2: Depositar. \n" +
            "Opção 3: Realizar empréstino. \n");
        Console.WriteLine(" Escolha uma opção do menu.");
        int opcaoescolhida = ((Convert.ToInt32(Console.ReadLine())));

        if (opcaoescolhida == 1)
        {
           conta.Saque(Convert.ToInt32(Console.ReadLine()));
        }
       
        if(opcaoescolhida == 2)
        {
            conta.Depositar(Convert.ToInt32(Console.ReadLine()));
        }
        if (opcaoescolhida == 3)
        {
            ContaEmpresa.RealizEmprestimo(Convert.ToInt32(Console.ReadLine()));
        }
        






        /*Alunos aluno = new Alunos();
        aluno.CPF = "000";
        aluno.Nome = "Pérolla Dias";

        Funcionarios funcionarios = new Funcionarios();
        funcionarios.CPF = "111";
        funcionarios.Nome = "Gabriely Budim";

        Gato gatos = new Gato();
        gatos.datanasc = DateOnly.Parse("01/03/2023");
        gatos.raca = "Ciamês";
        gatos.barulho();

        Cachorro cachorros = new Cachorro();
        cachorros.datanasc = DateOnly.Parse("10/04/2023");
        cachorros.raca = "Husk Siberiano";
        cachorros.barulho();
        */





    }
}