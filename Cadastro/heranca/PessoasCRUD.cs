using System;
using System.Collections.Generic;

namespace heranca
{
    public class PessoasCRUD : Pessoa
    {
        private List<Pessoa> lista = new List<Pessoa>(); //Foi criado uma lista Com o nome de Pessoa
        private Pessoa pessoa; //Foi criado um objeto pessoa            
        
        public void Cadastrar()
        {            
            pessoa = new Pessoa(); /*este objeto pessoa fica criando uma nova pessoa com novas informações sempre que o while voltar no começo do codigo,
                                   para assim definir uma nova pessoa com novas informações.*/

            //Comandos que serão passados para dentro do metodo "cadastrar"           
            Console.WriteLine("\n\t\t\t\t\tInsira seu nome: ");
            Console.Write("\t\t\t\t\t");
            pessoa.Nome = Console.ReadLine(); //pessoa.Nome = O nome esta sendo armazenado dentro do novo objeto pessoa

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

            if (EncontrarPesssoaNaLista(pessoa.CPF) == null)
            {
                lista.Add(pessoa);//esta adicionando o cadastro da pessoa dentro da lista
                Console.WriteLine("\t\t\t\t\tUsuário cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("\t\t\t\t\tUsuário já está cadastrado.");
            }

            Console.ReadKey();
        }

        private Pessoa BuscaDePessoas(string cpf)
        {
            foreach (Pessoa p in lista)
            {
                if (p != null)
                {
                    lista.Remove(p); // remover da lista o atributo que é igual a variavel 
                    Console.WriteLine("\n\t\t\t\t\tCadastro excluido com sucesso!");
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\tUsuário não possui cadastro");
                }

                Console.ReadKey();
            }
            return null;
        }

        //Metodo que mostra as informações da pessoa que foi cadastrada
        public void Listar()
        {
            //Este foreach diz sera listado as informaçoes da nova pessoa
            foreach (Pessoa p in lista)
            {
                p.MostrarInformacoes();
            }

            Console.ReadKey();
        }      

        public void Excluir()
        {          
            Console.WriteLine("\t\t\t\t\tInsira o CPF cadastrado: ");//Solicitei uma informação
            Console.Write("\n\t\t\t\t\t");
            var cpfParaBusca = Console.ReadLine(); //Armazena a informaçao pedida em uma variavel

            Pessoa pessoaExiste = EncontrarPesssoaNaLista(cpfParaBusca);

            if (pessoaExiste != null)
            {
                lista.Remove(pessoaExiste); // remover da lista o atributo que é igual a variavel 
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
            Console.WriteLine("\t\t\t\t\tQual pessoa você deseja alterar as informações? ");
            Console.Write("\t\t\t\t\t");
            var cpfParaBusca = Console.ReadLine();

            Pessoa p = EncontrarPesssoaNaLista(cpfParaBusca);

            Console.WriteLine("\t\t\t\t\tQual informação você deseja alterar? ");
            Console.Write("\t\t\t\t\t");
            var atributoDeTroca = Console.ReadLine();

            bool encontrar = ValidarAtributoDePessoaNaLista(atributoDeTroca);

            if (p != null && encontrar == true)
            {
                Console.WriteLine("\t\t\t\t\tInsira a nova informação: ");
                Console.Write("\t\t\t\t\t");
                var novoAtributo = Console.ReadLine();

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
        }//solid
    }   
}