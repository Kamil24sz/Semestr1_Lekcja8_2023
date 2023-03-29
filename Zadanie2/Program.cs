using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Konfigurator zestawu komputerowego");
            decimal koszyk = 0;

            Console.WriteLine("Wybierz procesor");
            Console.WriteLine("1.Intel Core i5-12400F - 807,19 zł");
            Console.WriteLine("2.Intel Core i3-12100F - 476,94 zł");
            Console.WriteLine("3.Intel Core i5-13600KF - 1 589 zł");

            int procesor = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (procesor)
            {
                case 1:
                    Console.WriteLine("Wybrano Intel Core i5-12400F");
                    koszyk = koszyk + 807.19m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                case 2:
                    Console.WriteLine("Wybrano Intel Core i3-12100F");
                    koszyk = koszyk + 476.94m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                case 3:
                    Console.WriteLine("Wybrano Intel Core i5-13600KF");
                    koszyk = koszyk + 1589m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                default:
                    Console.WriteLine("Wybrano niewłaściwą opcję");
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Wybierz kartę graficzną");
            Console.WriteLine("1.ASUS Radeon RX 6700 - 2 249 zł");
            Console.WriteLine("2.Gigabyte GeForce RTX 3060 - 1 899 zł");
            Console.WriteLine("3.Gigabyte GeForce RTX 3060 Ti - 2 299 zł");

            int kartaGraficzna = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (kartaGraficzna)
            {
                case 1:
                    Console.WriteLine("Wybrano ASUS Radeon RX 6700");
                    koszyk = koszyk + 2249m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                case 2:
                    Console.WriteLine("Wybrano Gigabyte GeForce RTX 3060");
                    koszyk = koszyk + 1899m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                case 3:
                    Console.WriteLine("Wybrano Gigabyte GeForce RTX 3060 Ti");
                    koszyk = koszyk + 2299m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                default:
                    Console.WriteLine("Wybrano niewłaściwą opcję");
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
            }

            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Wybierz płytę główną");
            Console.WriteLine("1.ASUS PRIME B660M-A - 563,81 zł");
            Console.WriteLine("2.Gigabyte B660 GAMING X - 712,87 zł");
            Console.WriteLine("3.ASUS PRIME H610M-D D4 - 429 zł");

            int plytaGlowna = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (plytaGlowna)
            {
                case 1:
                    Console.WriteLine("Wybrano ASUS PRIME B660M-A");
                    koszyk = koszyk + 563.81m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                case 2:
                    Console.WriteLine("Wybrano GGigabyte B660 GAMING X");
                    koszyk = koszyk + 712.87m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                case 3:
                    Console.WriteLine("Wybrano ASUS PRIME H610M-D D4");
                    koszyk = koszyk + 429m;
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
                default:
                    Console.WriteLine("Wybrano niewłaściwą opcję");
                    Console.WriteLine($"Kwota koszyka to {koszyk}");
                    break;
            }

            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine($"Stan końcowy koszyka to {koszyk}");
            Console.ReadLine();
        }
    }
}
