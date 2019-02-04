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
            do
            {
                Console.WriteLine("\tMenu de cadastros");
                Console.WriteLine("\n\t[F1] Para efetuar um cadastro" +
                                  "\n\t[F2] Para verificar lista de cadastro" +
                                  "\n\t[F3] Sair");
                Novo = Console.ReadKey();
                Console.Clear();

                if (Novo.Key == ConsoleKey.F1)//Ao clicar a tecla f1, vai ser iniciado um novo cadastro
                {
                    do//vai ser mostrado estas informações para a condição F1 de novo cadastro
                    {
                       lista.cadastrar(); //Dentro da classe ListaDePessoas foi criado um metodo cadastrar onde é passado todas as informaçoes necessarias para efetuar
                                          //um novo cadastro no console, essa linha é para queseja trazido estas informações para dentro do codigo  e dar continuidade.
                       Console.WriteLine("\tDeseja Continuar com o cadastro?");
                       Console.WriteLine("\n\t[F4] Sim" +
                                         "\n\t[F5] Não");

                       Novo = Console.ReadKey();//armazena as informações deste laço while dentro da variavel Novo, e lê as informaçoes inseridas
                       Console.Clear();

                    } while (Novo.Key == ConsoleKey.F4); //Nesta condição, esta sendo dito que quando foi apertado a tecla f4, eu quero efetuar um novo cadastro, 
                                                         //sendo assim, reiniciando este laço para eu poder cadastrar uma nova pessoa 
                }

                if (Novo.Key == ConsoleKey.F2)
                {
                    lista.listar(); //me traz as informações que foram acrescentadas dentro da lista
                    Console.Clear();
                }

            } while (Novo.Key != ConsoleKey.F3); // != diferente, sai do console de cadastro          
        }
    }
}

