using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double gasolina, etanol, numer = 0, valor1, valor2, total, altura, massa, IMC,;
            int quantidade = 0, opcao;
            string opcao;

            Console.WriteLine("escolha uma atividade");
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Exercício 5");

            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Clear();
                Console.WriteLine("Um veículo abastecido com etanol apresenta 70% da eficiência de um mesmo veículo abastecido com gasolina");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Insira o valor da gasolina");

                gasolina = Convert.ToDouble(Console.ReadLine);

                Console.Clear();

                Console.WriteLine("Insira o valor do etanol");

                etanol = Convert.ToDouble(Console.ReadLine());

                gasolina = gasolina * 0,70;

                Console.Clear();

                Console.WriteLine(gasolina);
                Console.WriteLine(etanol);

                if (gasolina <= etanol);
                {
                    Console.WriteLine();
                    Console.WriteLine("O etanol é mais eficiente");

                }

               



            }


        }
    }
}
