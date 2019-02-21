using System;
using System.Collections.Generic;

namespace CadastroPessoaCRUD //pode ter varios namespace...
{
    public class PessoasCRUD //Classe com acesso publico/modificador onde a class PessoasCRUD está herdando os atributos de Pessoa
    {
        private List<Pessoa> lista = new List<Pessoa>(); //Foi criado uma lista privada com o nome de lista        
        private Pessoa pessoa;                          //Foi criado um objeto pessoa            
        //instanciar pessoa em lista privada
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

            Console.ReadKey();
        }
      
        public void Listar()
        {
            foreach (Pessoa p in lista)
            {
                p.MostrarInformacoes();
            }

            Console.ReadKey();
        }      

        public void Excluir() 
        {          
            Console.WriteLine("\t\t\t\t\tInsira o CPF cadastrado: ");
            Console.Write("\n\t\t\t\t\t");
            var cpfParaBusca = Console.ReadLine(); 

            Pessoa pessoaExiste = EncontrarPesssoaNaLista(cpfParaBusca); 

            if (pessoaExiste != null)
            {
                lista.Remove(pessoaExiste); 
                Console.WriteLine("\n\t\t\t\t\tCadastro excluido com sucesso!");
            }
            else
            {
                Console.WriteLine("\t\t\t\t\tUsuário não possui cadastro");
            }

            Console.ReadKey();
        }
        
        public void Alterar() 
        {
            Console.WriteLine("\t\t\t\t\tInsira o CPF da pessoa: ");
            Console.Write("\t\t\t\t\t");
            var cpfParaBusca = Console.ReadLine();

            Pessoa pessoa = EncontrarPesssoaNaLista(cpfParaBusca);

            Console.WriteLine("\t\t\t\t\tQual informação você deseja alterar? ");
            Console.Write("\t\t\t\t\t");
            var atributoDeTroca = Console.ReadLine();

            bool encontrar = ValidarAtributoDePessoaNaLista(atributoDeTroca);

            if (pessoa != null && encontrar == true) 
            {
                Console.WriteLine("\t\t\t\t\tInsira a nova informação: ");
                Console.Write("\t\t\t\t\t");
                var novoAtributo = Console.ReadLine();
                
                if (atributoDeTroca == "Nome")
                {
                    pessoa.Nome = novoAtributo;
                }

                if (atributoDeTroca == "Idade")
                {
                    pessoa.Idade = novoAtributo;
                }

                if (atributoDeTroca == "Cor")
                {
                    pessoa.Cor = novoAtributo;
                }

                if (atributoDeTroca == "Altura")
                {
                    pessoa.Altura = novoAtributo;
                }

                if (atributoDeTroca == "CPF")
                {
                    pessoa.CPF = novoAtributo;
                }

                Console.WriteLine("\t\t\t\t\tAlteração realizada com sucesso!");
            }
            else 
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

            Pessoa pessoa = EncontrarPesssoaNaLista(cpfParaBusca);

            if (pessoa != null)
            {
                pessoa.MostrarInformacoes();
            }
            else
            {
                Console.WriteLine("\t\t\t\t\tNão Existe");
            }

            Console.ReadKey();
         }
        private Pessoa EncontrarPesssoaNaLista(string cpf)
        {
        /*
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].CPF == cpf)
                {
                    return lista[i];
                }
            }
        */
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
        private bool ValidarAtributoDePessoaNaLista(string atributo)
        {
            if (atributo == "Nome" || atributo == "CPF" || atributo == "Altura" || atributo == "Cor" || atributo == "Idade")
            {
                return true;
            }
            return false; //boll
        }
    }    
}        