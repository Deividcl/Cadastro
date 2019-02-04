using System;
using System.Collections.Generic;
using System.Text;

namespace heranca
{
    public class ListaDePessoas
    {
        private List<Pessoa> lista = new List<Pessoa>(); //Foi criado uma lista Com o nome de Pessoa
        private Pessoa pessoa; //Foi criado um objeto pessoa        

        public ListaDePessoas()
        {            

        }

        public void cadastrar()
        {
            pessoa = new Pessoa(); /*este obejeto pessoa, ele fica criando uma nova pessoa com novas informações sempre que o while voltar no começo do codigo,
                                   para assim definir uma nova pessoa com novas informações.*/

            //Comandos que serão passados para dentro do metodo "cadastrar"
            Console.WriteLine("\n\tInsira seu nome: ");
            Console.Write("\t");
            pessoa.Nome = Console.ReadLine(); //pessoa.Nome = O nome esta sendo armazenado dentro do novo objeto pessoa

            Console.WriteLine("\tInsira sua idade: ");
            Console.Write("\t");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\tInsira sua Cor: ");
            Console.Write("\t");
            pessoa.Cor = Console.ReadLine();

            Console.WriteLine("\tInsira sua Altura: ");
            Console.Write("\t");
            pessoa.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\tInsira seu CPF: ");
            Console.Write("\t");
            pessoa.CPF = Console.ReadLine();

            //esta adicionando "pessoa" dentro de lista
            lista.Add(pessoa);
        }
        //Metodo que mostra as informações da pessoa que foi cadastrada
        public void listar()
        {
            //Este foreach diz sera listado as informaçoes da nova pessoa
            foreach (Pessoa l in lista)
            {
                Console.WriteLine(l.Nome); //Me retorna a informação que eu quero da lista "l"
                Console.ReadKey();
            }
        }
    }   
}
