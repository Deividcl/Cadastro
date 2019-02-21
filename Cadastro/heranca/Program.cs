using System; 

namespace CadastroPessoaCRUD
{
    public class Program //Acesso publico com o retorno de uma classe nomeada Program (Principal)
    {
        public static void Main(string[] args) //Acesso public de uma chave que nao pode ser instanciada (static) que nao tem retorno Com o nome do metodo (main) - (recebe argumentos)
        {
            ConsoleKeyInfo opcaoDoUsuario; //Descreve a chave do console que foi pressionada, incluindo o caractere representado pela chave do console e o 
                                           //estado das teclas modificadoras          
            PessoasCRUD pessoasCRUD = new PessoasCRUD(); //Foi instanciado um novo objeto dentro da class program
            
            do //Inicio do laço while -- definindo que o laço será repetido pelo menos 1 vez
            {
                Console.WriteLine("\t\t\t\t\t\tMenu de cadastros");
                Console.WriteLine("\n\t\t\t\t\t[F1] Para efetuar um cadastro" +
                                  "\n\t\t\t\t\t[F2] Para verificar lista de cadastro" +
                                  "\n\t\t\t\t\t[F3] Alterar  " +
                                  "\n\t\t\t\t\t[F4] Buscar" +
                                  "\n\t\t\t\t\t[F5] Excluir" +
                                  "\n\t\t\t\t\t[F8] Sair");
            
                opcaoDoUsuario = Console.ReadKey(); //Armazena o dado digitado dentro da chave (opcaoDoUsuario) 
                Console.Clear();
            
                if (opcaoDoUsuario.Key == ConsoleKey.F1) //Ao clicar a tecla f1, vai ser iniciado um novo cadastro
                { 
                    pessoasCRUD.Cadastrar(); //Dentro da classe ListaDePessoas foi criado um metodo cadastrar onde é passado todas as informaçoes necessarias para efetuar
                                             //um novo cadastro no console, essa linha é para queseja chamada estas informações para dentro do codigo  e dar continuidade.
                     Console.Clear();
                }
            
                if (opcaoDoUsuario.Key == ConsoleKey.F2)
                {
                    pessoasCRUD.Listar(); //me traz as informações que foram acrescentadas dentro da lista
                    Console.Clear();
                }
            
                if (opcaoDoUsuario.Key == ConsoleKey.F3)
                {
                    pessoasCRUD.Alterar();
                    Console.Clear();
                }
            
                if (opcaoDoUsuario.Key == ConsoleKey.F4)
                {
                    pessoasCRUD.Buscar();
                    Console.Clear();
                }
            
                if (opcaoDoUsuario.Key == ConsoleKey.F5)
                {
                    pessoasCRUD.Excluir();
                    Console.Clear();
                }

            } while (opcaoDoUsuario.Key != ConsoleKey.F8); // != diferente, sai do console de cadastro          
        } 
    }
}

