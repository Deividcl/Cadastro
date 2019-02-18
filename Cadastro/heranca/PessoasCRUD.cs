using System;
using System.Collections.Generic;

namespace heranca
{
    public class PessoasCRUD : Pessoa //Classe com acesso publico onde a class PessoasCRUD está herdando os atributos de Pessoa
    {
        private List<Pessoa> lista = new List<Pessoa>(); //Foi criado uma lista privada com o nome de lista
        private Pessoa pessoa;                          //Foi criado um objeto pessoa            
        
        public void Cadastrar() //Metodo publico sem retorno com o nome do metodo Cadastrar -- não possui argumentos
        {            
            pessoa = new Pessoa(); /*este objeto pessoa fica criando uma nova pessoa com novas informações sempre que o while voltar no começo do codigo,
                                   para assim definir uma nova pessoa com novas informações.*/

            //Comandos que serão passados para dentro do metodo "cadastrar"           
            Console.WriteLine("\n\t\t\t\t\tInsira seu nome: ");
            Console.Write("\t\t\t\t\t");
            pessoa.Nome = Console.ReadLine(); //pessoa.Nome = O nome digitado será armazenado dentro do atributo Nome como uma nova pessoa

            Console.WriteLine("\t\t\t\t\tInsira sua idade: ");
            Console.Write("\t\t\t\t\t");
            pessoa.Idade = Console.ReadLine();

            Console.WriteLine("\t\t\t\t\tInsira sua Cor: ");
            Console.Write("\t\t\t\t\t");
            pessoa.Cor = Console.ReadLine();

            Console.WriteLine("\t\t\t\t\tInsira sua Altura: ");
            Console.Write("\t\t\t\t\t");
            pessoa.Altura = Console.ReadLine();

            Console.WriteLine("\t\t\t\t\tInsira seu CPF: ");
            Console.Write("\t\t\t\t\t");
            pessoa.CPF = Console.ReadLine();

            if (EncontrarPesssoaNaLista(pessoa.CPF) == null) //se o metodo encontrarPessoaNaLista possuir uma pessoa com o cpf vazio ele vai armazenar uma nova pessoa com um novo cpf
            {
                lista.Add(pessoa);//esta adicionando o cadastro da pessoa dentro da lista
                Console.WriteLine("\t\t\t\t\tUsuário cadastrado com sucesso!"); //e retorna uma mensagem de sucesso
            }
            else // mas se o metodo possuir uma pessoa com o cpf ja cadastrado, ele nao cadastra e retorna uma msg informando que ja o possui
            {
                Console.WriteLine("\t\t\t\t\tUsuário já está cadastrado.");
            }

            Console.ReadKey(); //mantem as informaçoes na tela
        }

        private Pessoa BuscaDePessoas(string cpf) //metodo privado onde só vai ser ultilizado dentro da classe PessoasCRUD , onde vai retornar uma pessoa
        // nome do metodo BuscaDePessoas com um argumento string por ser uma cadeia de caracteres e cpf, que seria o atributo analisado
        {                                
            foreach (Pessoa p in lista) //itera dentro da lista uma pessoa
            {
                if (p != null) //se Pessoa que seria p, nao estiver vazia ele a remove
                {
                    lista.Remove(p); //lista= onde é armazedado as informaçoes e Remove(p) remove a pessoa da lista onde o atributo cpf ja exista
                    Console.WriteLine("\n\t\t\t\t\tCadastro excluido com sucesso!");
                }
                else //Se estiver vazio ele me retorna uma mensagem de aviso
                {
                    Console.WriteLine("\t\t\t\t\tUsuário não possui cadastro");
                }

                Console.ReadKey(); //mantem as informações na tela
            }
            return null; //o atributo de retorno foi vazio, indo para a condição if acima.
        }

        //Metodo publico sem retorno, que mostra as informações da pessoa que foi cadastrada
        public void Listar()
        {
            //Este foreach diz sera listado as informaçoes da nova pessoa
            foreach (Pessoa p in lista)
            {
                p.MostrarInformacoes();
            }

            Console.ReadKey();
        }      

        public void Excluir() //Metodo publico sem retorno com o nome do metodo Excluir() sem nenhum argumento
        {          
            Console.WriteLine("\t\t\t\t\tInsira o CPF cadastrado: ");//Solicitei uma informação
            Console.Write("\n\t\t\t\t\t");
            var cpfParaBusca = Console.ReadLine(); //Armazena a informaçao pedida em uma variavel

            Pessoa pessoaExiste = EncontrarPesssoaNaLista(cpfParaBusca); //instancio uma variavel em Pessoa onde sera recebido as informações do Metodo Privado
            //EncontrarPessoaNaLista que recebe como argumento o informação armazenada na variavel cpfParaBusca

            if (pessoaExiste != null) //Se a variavel pessoaExiste nao estiver vazia
            {
                lista.Remove(pessoaExiste); // remover da lista o atributo que é igual a variavel 
                Console.WriteLine("\n\t\t\t\t\tCadastro excluido com sucesso!");
            }
            else //caso esteja vazia ele me retorna uma mensagem 
            {
                Console.WriteLine("\t\t\t\t\tUsuário não possui cadastro");
            }

            Console.ReadKey();
        }
        
        public void Alterar() //Metodo publico sem retorno nomeado como alterar() sem argumentos
        {
            Console.WriteLine("\t\t\t\t\tQual pessoa você deseja alterar as informações? ");
            Console.Write("\t\t\t\t\t");
            var cpfParaBusca = Console.ReadLine();

            Pessoa p = EncontrarPesssoaNaLista(cpfParaBusca);//Cria uma variavel p em Pessoa que recebe EncontrarPessoaNaLista com variavel cpfParaBusca como argumento

            Console.WriteLine("\t\t\t\t\tQual informação você deseja alterar? ");
            Console.Write("\t\t\t\t\t");
            var atributoDeTroca = Console.ReadLine();

            bool encontrar = ValidarAtributoDePessoaNaLista(atributoDeTroca); //uma variavel booleana onde so me retorna true ou false
            //recebe as informaçoes de ValidarAtributoDePessoaNaLista rebenedo como argumento a variavel atributo de troca.

            if (p != null && encontrar == true) //se p nao estiver vazio e a variavel booleana encontrar for verdadeiro
            {
                Console.WriteLine("\t\t\t\t\tInsira a nova informação: ");
                Console.Write("\t\t\t\t\t");
                var novoAtributo = Console.ReadLine();

                //ele solicita mais uma informaçao e condiciona a novas atribuições dependendo do valor escolhido anteriormente
                if (atributoDeTroca == "Nome")
                {
                    p.Nome = novoAtributo;
                }

                if (atributoDeTroca == "Idade")
                {
                    p.Idade = novoAtributo;
                }

                if (atributoDeTroca == "Cor")
                {
                    p.Cor = novoAtributo;
                }

                if (atributoDeTroca == "Altura")
                {
                    p.Altura = novoAtributo;
                }

                if (atributoDeTroca == "CPF")
                {
                    p.CPF = novoAtributo;
                }

                Console.WriteLine("\t\t\t\t\tAlteração realizada com sucesso!");
            }
            else //caso as condições nao forem verdadeiras ele me retorna uma informação de nao sucesso
            {
                Console.WriteLine("\t\t\t\t\tUsuário não possui cadastro ou informação incorreta ");
            }

            Console.ReadKey();
        }

        public void Buscar()
        {
            Console.WriteLine("\t\t\t\t\tDigite o CPF para fazer a busca: ");
            Console.Write("\t\t\t\t\t");
            var cpfParaBusca = Console.ReadLine();

            Pessoa p = EncontrarPesssoaNaLista(cpfParaBusca);

            if (p != null)
            {
                p.MostrarInformacoes();
            }
            else
            {
                Console.WriteLine("\t\t\t\t\tNão Existe");
            }

            Console.ReadKey();
         }
        //private ou publico = visibilidade da função, Pessoa = Retorno, "EncontrarPesssoaNaLista" nome do metodo(parametros);
        private Pessoa EncontrarPesssoaNaLista(string cpf)
        {
            //foreach = iteração dentro da lista de elementos
            foreach (Pessoa p in lista) 
            {
                if (p.CPF == cpf) 
                {
                    return p;
                }
            }
            return null; 
        }
        //
        private bool ValidarAtributoDePessoaNaLista(string atributo)
        {
            if (atributo == "Nome" || atributo == "CPF" || atributo == "Altura" || atributo == "Cor" || atributo == "Idade")
            {
                return true;
            }
            return false; //boll
        }//Solid Single Responsibility Principle = Dar a classe uma responsabilidade, ex: se a classe for retangulo, ela tem a responsabilidade de 
    }    //conter ações referentes a ele.
}        //Solid 