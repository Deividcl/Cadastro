using System;

namespace CadastroPessoaCRUD
{
    public class Pessoa
    {
        public string Nome { get; set; } //metodo publico que retorna uma string e/ou cadeia de caracteres atribuido como Nome onde ele tem um acessador
        public string Idade { get; set; } //get e set, onde grava a informação e a lê.
        public string Cor { get; set; }
        public string Altura { get; set; }
        public string Ocupacao { get; set; }
        public string CPF { get; set; }
        //private string teste;

        public void MostrarInformacoes()
        {
            Console.WriteLine("\n\t |Nome: " + Nome);
            Console.Write("\t |Idade: " + Idade + " |Raça: " + Cor + " |Altura: " + Altura + " |CPF: " + CPF + "\n");
        }
        /*
        public string GetTeste()
        {
            return teste;
        }

        public void SetTeste(string teste)
        {
            this.teste = teste;
        }
        */
    }
}