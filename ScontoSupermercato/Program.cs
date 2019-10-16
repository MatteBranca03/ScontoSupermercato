using System;

namespace ScontoSupermercato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il totale della spesa");
            double a = double.Parse(Console.ReadLine());
            double s = (a * 20) / 100;
            if (a < 100)
            {
                Console.WriteLine($"l'importo è {a} ");
                Console.ReadLine();
            }
            else
            {
                double importo = a - s;
                Console.WriteLine($"l'importo scontato è {importo:c}");
                Console.ReadLine();
            }
        }
    }
}
