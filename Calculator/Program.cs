using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");

            short res = Convert.ToInt16(Console.ReadLine());

            if (res == 1) Soma();
            if (res == 2) Subtracao();
            if (res == 3) Divisao();
            if (res == 4) Multiplicacao();
            if (res == 5) Environment.Exit(0);
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int result = valor1 + valor2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da Soma é: {result}");

            Console.WriteLine("Press Enter para fazer mais calculos.");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int result = valor1 - valor2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da Subtracao é: {result}");

            Console.WriteLine("Press Enter para fazer mais calculos.");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int result = valor1 / valor2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da Divisao é: {result}");

            Console.WriteLine("Press Enter para fazer mais calculos.");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int result = valor1 * valor2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da Multiplicacao é: {result}");

            Console.WriteLine("Press Enter para fazer mais calculos.");
            Console.ReadKey();
            Menu();
        }
    }
}


