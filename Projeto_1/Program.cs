using Projeto_1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 1 - C#");

            //Comentário de 1 linha

            /*
             * comentário de Várias
             * Linhas
             */

            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Seu nome é:" + nome);

            Console.WriteLine($"Seu nome é: {nome}");

            Console.WriteLine("SOMANDO 2 VALORES!!!");

            Console.WriteLine("Informe o Primeiro Valor: ");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            int valor2 = Int32.Parse(Console.ReadLine());   


            int total = valor1+ valor2;

            Console.WriteLine($"Total: {total}");

            Somar sm = new Somar(valor1,valor2);
            Console.WriteLine($"Total: {sm.Calcular()}");
            

            Console.ReadLine();
        }
    }
}
