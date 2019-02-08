using heranca;
using System;
namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Novo; //Descreve a chave do console que foi pressionada, incluindo o caractere representado pela chave do console e o estado das teclas
                                 //modificadoras          

            ListaDePessoas lista = new ListaDePessoas(); //Foi instanciado um novo objeto lista dentro da class program
            ListaDePessoas pessoas = new ListaDePessoas();
            AlterarDadosCadastrados ListaDeCadastrados = new AlterarDadosCadastrados();
            do
            {
                Console.WriteLine("\t\t\t\t\t\tMenu de cadastros");
                Console.WriteLine("\n\t\t\t\t\t[F1] Para efetuar um cadastro" +
                                  "\n\t\t\t\t\t[F2] Para verificar lista de cadastro" +
                                  "\n\t\t\t\t\t[F3] Alterar  " +
                                  "\n\t\t\t\t\t[F4] Buscar" +
                                  "\n\t\t\t\t\t[F5] Excluir" +
                                  "\n\t\t\t\t\t[F8] Sair");

                Novo = Console.ReadKey();
                Console.Clear();

                if (Novo.Key == ConsoleKey.F1)//Ao clicar a tecla f1, vai ser iniciado um novo cadastro
                {
                    do//vai ser mostrado estas informações para a condição F1 de novo cadastro
                    {
                        lista.Cadastrar(); //Dentro da classe ListaDePessoas foi criado um metodo cadastrar onde é passado todas as informaçoes necessarias para efetuar
                                           //um novo cadastro no console, essa linha é para queseja trazido estas informações para dentro do codigo  e dar continuidade.
                        Console.WriteLine("\t\t\t\t\tDeseja Continuar com o cadastro?");
                        Console.WriteLine("\n\t\t\t\t\t[F1] Sim" +
                                          "\n\t\t\t\t\t[F9] Não");

                        Novo = Console.ReadKey();//armazena as informações deste laço while dentro da variavel Novo, e lê as informaçoes inseridas
                        Console.Clear();

                    } while (Novo.Key == ConsoleKey.F1); //Nesta condição, esta sendo dito que quando foi apertado a tecla f4, eu quero efetuar um novo cadastro, 
                                                         //sendo assim, reiniciando este laço para eu poder cadastrar uma nova pessoa 
                }

                if (Novo.Key == ConsoleKey.F2)
                {
                    lista.ListarCadastrosEfetuados(); //me traz as informações que foram acrescentadas dentro da lista
                    Console.Clear();
                }

                if (Novo.Key == ConsoleKey.F3)
                {
                    do
                    {
                        lista.AlterarDadosCadastrais();
                        Console.WriteLine("\n\t\t\t\t Deseja efetuar uma nova alteração? ");
                        Console.WriteLine("\t\t\t\t\t[F1] Sim" +
                                          "\t[F2] Não");
                        Novo = Console.ReadKey();
                        Console.Clear();
                    } while (Novo.Key == ConsoleKey.F1);
                }

                if (Novo.Key == ConsoleKey.F4)
                {
                    do
                    {
                        lista.BuscarUsuarioCadastrado();

                        Console.WriteLine("\n\t\t\t\t Deseja efetuar uma nova busca? ");
                        Console.WriteLine("\t\t\t\t\t[F1] Sim" +
                                          "\t[F2] Não");

                        Novo = Console.ReadKey();
                        Console.Clear();

                    } while (Novo.Key == ConsoleKey.F1);
                }

                if (Novo.Key == ConsoleKey.F5)
                {
                    do
                    {
                        lista.ExcluirCadastro();

                        Console.WriteLine("\n\t\t\t\t\tDeseja efetuar uma nova exclusão? ");
                        Console.Write("\n\t\t\t\t\t [F1] Sim   |   [F2] Não");

                        Novo = Console.ReadKey();
                        Console.Clear();

                    } while (Novo.Key == ConsoleKey.F1);
                }     

            } while (Novo.Key != ConsoleKey.F8); // != diferente, sai do console de cadastro          
        }   
    }
}

