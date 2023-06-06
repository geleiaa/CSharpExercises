using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Start(6);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("s = segundos, Ex: 10s = 10 segundos");
            Console.WriteLine("m = minutos, Ex: 1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo quer contar????");

            string data = Console.ReadLine().ToLower();
            char timeType = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (timeType == 'm') multiplier = 60;

            if (time == 0) System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime + " segundos");
                Thread.Sleep(500);
            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado");
            Thread.Sleep(500);
        }
    }
}