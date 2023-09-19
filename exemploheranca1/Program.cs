using exemploheranca1.Classes;
using exemploheranca1.Exercicio2;
using exemploheranca1.Exercicio3;
public class Program
{
    static void Main(string[] args)
    {
        int Numeroconta = 01;
        int Agencia = 05;
       
        while (true)
        {
            Console.WriteLine("Digite \n" +
            "1 para conta comum \n" +
            "2 para conta estudante \n" +
            "3 para conta empresarial\n" +
            "4 para sair \n");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o titular da conta: \n");
            string Titularconta = Console.ReadLine();


            if (opcao == 1)
            {
                Conta c = new Conta(Numeroconta, Agencia, Titularconta, 0);
                Numeroconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair \n");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor para depositar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valor);
                        Console.WriteLine($"Novo saldo: {c.Saldoconta} \n");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor para sacar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Saque(valor);
                        Console.WriteLine($"Novo saldo: {c.Saldoconta} \n");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite o CPF do estudante: ");
                string CPF = Console.ReadLine();

                Console.WriteLine("Informe a Instituição: ");
                string NomeInst = Console.ReadLine();

                ContaEstudante contaEstudante = new ContaEstudante(100, CPF, NomeInst, Numeroconta, Agencia, Titularconta, 0);
                Numeroconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair\n");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor para depositar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        contaEstudante.Depositar(valor);
                        Console.WriteLine($"Novo saldo: {contaEstudante.Saldoconta}\n");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor para sacar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        contaEstudante.Saque(valor);
                        Console.WriteLine($"Novo saldo: {contaEstudante.Saldoconta}\n");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (opcao == 3)
            {
                ContaEmpresa contaEmpresa = new ContaEmpresa(10, 1000, Numeroconta, Agencia, Titularconta, 0);
                Numeroconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar, 3 para fazer empréstimo e 4 para sair. \n");
                    opcao = Convert.ToInt32(Console.ReadLine());

                  if(opcao == 1)
                    {
                        Console.WriteLine("Digite o valor para depositar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        contaEmpresa.Depositar(valor);
                        Console.WriteLine($"Novo saldo: {contaEmpresa.Saldoconta}\n");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor para sacar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        contaEmpresa.Saque(valor);
                        Console.WriteLine($"Novo saldo: {contaEmpresa.Saldoconta}\n");
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Digite o valor para empréstimo: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        contaEmpresa.RealizEmprestimo(valor);
                        Console.WriteLine($"Novo saldo: {contaEmpresa.Saldoconta}\n");
                    }
                    else if (opcao == 4)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (opcao == 4)
            {
                break;
            }
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