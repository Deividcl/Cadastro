using System;

namespace heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Cor { get; set; }
        public string Altura { get; set; }
        public string Ocupacao { get; set; }
        public string CPF { get; set; }

        public void MostrarInformacoes()
        {
            Console.WriteLine("\n\t |Nome: " + Nome);
            Console.Write("\t |Idade: " + Idade + " |Raça: " + Cor + " |Altura: " + Altura + " |CPF: " + CPF + "\n");
        }
    }
}