using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja8_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 -> "1 dzień tygodnia to poniedziałek"
            // 3 -> "3 dzień tygodnia to środa"

            Console.WriteLine("Podaj mi numer dnia tygodnia");
            int dzien = int.Parse(Console.ReadLine());

            if (dzien == 1)
            {
                Console.WriteLine($"{dzien} dzień tygodnia to poniedziałek");
            }
            else if (dzien == 2)
            {
                Console.WriteLine($"{dzien} dzień tygodnia to wtorek");
            }
            else if (dzien == 3)
            {
                Console.WriteLine($"{dzien} dzień tygodnia to środa");
            }
            else if (dzien == 4)
            {
                Console.WriteLine($"{dzien} dzień tygodnia to czwartek");
            }
            else if (dzien == 5)
            {
                Console.WriteLine($"{dzien} dzień tygodnia to piątek");
            }
            else if (dzien == 6)
            {
                Console.WriteLine($"{dzien} dzień tygodnia to sobota");
            }
            else if (dzien == 7)
            {
                Console.WriteLine($"{dzien} dzień tygodnia to niedziela");
            }
            else
            {
                Console.WriteLine("Podałeś niewłaściwy numer tygodnia");
            }

            //SWITCH
            switch (dzien)
            {
                case 1: // to jest to samo co if(dzien == 1)
                    Console.WriteLine($"{dzien} dzień tygodnia to poniedziałek");
                    break;
                case 2:
                    Console.WriteLine($"{dzien} dzień tygodnia to wtorek");
                    break;
                case 3:
                    Console.WriteLine($"{dzien} dzień tygodnia to środa");
                    break;
                case 4:
                    Console.WriteLine($"{dzien} dzień tygodnia to czwartek");
                    break;
                case 5:
                    Console.WriteLine($"{dzien} dzień tygodnia to piątek");
                    break;
                case 6:
                    Console.WriteLine($"{dzien} dzień tygodnia to sobota");
                    break;
                case 7:
                    Console.WriteLine($"{dzien} dzień tygodnia to niedziela");
                    break;
                default:  //to tak jak ostatni else
                    Console.WriteLine("Nieprawidłowy dzień tygodnia");
                    break;
            }

            // Zadanie z tłumaczeniem ocen
            Console.WriteLine("Podaj jaką ocenę dostałeś");
            char ocena = char.Parse(Console.ReadLine()); // char przechowuje pojedyncze znaki '3'
            ocena = char.Parse(ocena.ToString().ToUpper());

            switch (ocena)
            {
                case '6':
                    Console.WriteLine("Celujacy");
                    break;
                case 'A':
                case '5':
                    Console.WriteLine("Bardzo-dobry");
                    break;
                case 'B':
                case '4':
                    Console.WriteLine("Dobry");
                    break;
                case 'C':
                case '3':
                    Console.WriteLine("Dostateczny");
                    break;
                case 'D':
                case '2':
                    Console.WriteLine("Dopuszczający");
                    break;
                case 'F':
                case '1':
                    Console.WriteLine("Niedostateczny");
                    break;
                default:
                    Console.WriteLine("Ocena nieprawidłowa");
                    break;
            }



            Console.ReadLine();
        }
    }
}