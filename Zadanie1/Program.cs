using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj Łowco, na jaką poczwarę polujesz?");
            string potwór = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"{potwór} mówisz... Niech pomyślę...");

            //3 sekundy przerwy dopiero później opis potwora
            Thread.Sleep(3000);

            Console.Clear();


            switch (potwór.ToLower())
            {
                case "bazyliszek":
                    Console.WriteLine("Jeden z najbardziej znanych przedstawicieli ");
                    Console.WriteLine("drakonidów to owiany złą sławą bazyliszek, zdolny przemieniać");
                    Console.WriteLine("ludzi w kamień tylko przy pomocy swojego wzroku.");
                    break;

                case "wiverna":
                    Console.WriteLine("Podobnie jak opisywane wcześniej widłogony, także i wiverny często są mylone");
                    Console.WriteLine("ze smokami, chociaż ustępują im zdecydowanie rozmiarem oraz brakiem");
                    Console.WriteLine("możliwości wytwarzania ognistego oddechu.");
                    break;

                case "gryf":
                    Console.WriteLine("Gryf to właściwie uzbrojona w skrzydła wersja lwa o szponach orła. Czasami nazywa");
                    Console.WriteLine("się go Inogiem, lecz bez względu na miano to poważny przeciwnik. Chcąc rzucić mu");
                    Console.WriteLine("wyzwanie, kiedyś wystarczyło udać się wysoko w góry, gdzie gryfy zakładają swoje gniazda.");
                    break;

                case "harpia":
                    Console.WriteLine("Harpie to stwory o magicznym rodowodzie. Mają głowy i tułów kobiet, jak też");
                    Console.WriteLine("wzrostem dorównują człowiekowi, lecz na tym lista podobieństw względem rodzaju");
                    Console.WriteLine("ludzkiego wyczerpuje się. Posiadają nogi i skrzydła niczym drapieżne sępy");
                    break;

                case "sukkub":
                    Console.WriteLine("Znajdą się śmiałkowie, którzy wręcz z otwartymi ramionami powitaliby");
                    Console.WriteLine("zainteresowanie ze strony sukkuba. Nie ma w tym nic dziwnego, bowiem te demony");
                    Console.WriteLine("wyglądają niczym piękne oraz ponętne kobiety.");
                    break;

                default:
                    Console.WriteLine("Niestety, takie gadziny to ja nie znam");
                    break;
            }

            Console.ReadLine();
        }
    }
}
