using System;
using System.Collections.Generic;

namespace heranca
{
    public class ListaDePessoas : Pessoa
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
            var ID = Console.ReadLine();

            bool cadastro = false;

            foreach (Pessoa pessoa in lista)
            {
                if (pessoa.CPF == ID)
                {
                    Console.WriteLine("\t\t\t\t\tCPF Já cadastrado");
                    cadastro = true;
                    break;
                }
            }

            if (cadastro == false)
            {
                pessoa.CPF = ID; //Ja foi adicionado a lista neste momento.
                lista.Add(pessoa);//esta adicionando o cadastro da pessoa dentro da lista 
            }                    
        }        

        //Metodo que mostra as informações da pessoa que foi cadastrada
        public void ListarCadastrosEfetuados()
        {
            //Este foreach diz sera listado as informaçoes da nova pessoa
            foreach (Pessoa l in lista)
            {
                Console.WriteLine("\n\t |Nome: " + l.Nome); 
                Console.Write("\t |Idade: " + l.Idade + " |Raça: " + l.Cor + " |Altura: " + l.Altura + " |CPF: " + l.CPF + "\n"); //Me retorna a informação que eu quero da lista "l")
            }
            Console.ReadKey();
        }      

        public void ExcluirCadastro()
        {          
            Console.WriteLine("\t\t\t\t\tInsira o CPF cadastrado: ");//Solicitei uma informação
            Console.Write("\n\t\t\t\t\t");
            var atributo = Console.ReadLine(); //Armazena a informaçao pedida em uma variavel

            bool naoExiste = false;

            foreach (Pessoa ex in lista) //verifica na lista a informação passada
            {                
                if (ex.CPF == atributo) //Se o nome passado for o mesmo que o da lista, (deletar é onde foi armazedado a informaçao passada)
                {
                    lista.Remove(ex); // remover da lista o atributo que é igual a variavel 
                    Console.WriteLine("\n\t\t\t\t\tCadastro excluido com sucesso!");
                    naoExiste = true;
                    Console.ReadKey();
                    break;
                }
                
            } if (naoExiste == false)
            {
                Console.WriteLine("\t\t\t\t\tUsuário não possui cadastro");
                Console.ReadKey();
            }
        }
        public void AlterarDadosCadastrais()
        {
            Console.WriteLine("\t\t\t\t\tQual informação você deseja alterar? ");
            Console.Write("\t\t\t\t\t");
            var atributoDeTroca = Console.ReadLine();

            Console.WriteLine("\t\t\t\t\tDe qual pessoa? ");
            Console.Write("\t\t\t\t\t");
            var atributoASerTrocado = Console.ReadLine();

            Console.WriteLine("\t\t\t\t\tInsira a nova informação: ");
            Console.Write("\t\t\t\t\t");
            var novoAtributo = Console.ReadLine();

            Console.Clear();

            foreach (Pessoa alterando in lista)
            {
                if (atributoDeTroca == "Nome" && atributoASerTrocado == alterando.Nome)
                {
                    alterando.Nome = novoAtributo;
                }

                if (atributoDeTroca == "Idade" && atributoASerTrocado == alterando.Nome)
                {
                    alterando.Idade = novoAtributo;
                }

                if (atributoDeTroca == "Cor" && atributoASerTrocado == alterando.Nome)
                {
                    alterando.Cor = novoAtributo;
                }

                if (atributoDeTroca == "Altura" && atributoASerTrocado == alterando.Nome)
                {
                    alterando.Altura = novoAtributo;
                }

                if (atributoDeTroca == "CPF" && atributoASerTrocado == alterando.Nome)
                {
                    alterando.CPF = novoAtributo;
                }
            }
        }

        public void BuscarUsuarioCadastrado()
        {
            Console.WriteLine("\t\t\t\t\tDigite o CPF para fazer a busca: ");
            Console.Write("\t\t\t\t\t");
            var busca = Console.ReadLine();

            bool possuiRegistro = false;

            foreach(Pessoa busc in lista)
            {
                if (busc.CPF == busca)
                {
                    lista.Contains(busc);
                    Console.WriteLine("\t |Nome: " + busc.Nome + "\t |Idade: " + busc.Idade + "\t |Raça: " + busc.Cor + "\t |Altura: " + busc.Altura + "\t |CPF: " + busc.CPF + "\n");
                    possuiRegistro = true;
                    Console.ReadKey();
                    break;
                }
            }

            if (possuiRegistro == false)
            {
                Console.WriteLine("\t\t\t\t\tNão Existe");
                Console.ReadKey();
            }
         }        
    }   
}