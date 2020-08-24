using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia criada
            Pessoa L1 = new Pessoa();
            Pessoa L2 = new Pessoa();
             

            //Entrada dos valores da primeira pessoa
            Console.WriteLine("Dados da pessoa 1: ");
            Console.WriteLine("Nome: ");
            L1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            L1.Idade = int.Parse(Console.ReadLine());

            //Entrada dos valores da segunda pessoa
            Console.WriteLine("Dados da pessoa 2: ");
            Console.WriteLine("Nome: ");
            L2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            L2.Idade = int.Parse(Console.ReadLine());

            //Condicional para comparar quem é a pessoa mais velha.

            if(L1.Idade > L2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + L1.Nome);
            }

            else 
            {
                Console.WriteLine ("Pessoa mais velha: " + L2.Nome);
            }
    }
}
