using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobásoskocka6767
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random veletlen = new Random();
            int szint = 1;

            Console.WriteLine("Dobókockás játék!");
            Console.WriteLine("Juss el az 5. szintre! Minden helyes válasz után továbblépsz.");
            Console.WriteLine("A dobott számhoz egy kérdés tartozik.");
            Console.WriteLine("Nyomj meg egy billentyűt a dobáshoz!");

            while (szint < 5)
            {
                bool joValasz = false;

                while (joValasz == false)
                {
                    Console.WriteLine();
                    Console.Write("Dobj a következő szintért!");
                    Console.ReadKey(true);

                    int dobas = veletlen.Next(1, 7);
                    Console.WriteLine();
                    Console.WriteLine("Ezt dobtad: " + dobas);

                    string kerdes = "";
                    string helyesValasz = "";

                    switch (dobas)
                    {
                        case 1:
                            kerdes = "1. kérdés: 44 + 23?";
                            helyesValasz = "67";
                            break;
                        case 2:
                            kerdes = "2. ki volt az elsö magyar király?";
                            helyesValasz = "I. István";
                            break;
                        case 3:
                            kerdes = "3. kérdés: mikor írta kölcsey a himnuszt";
                            helyesValasz = "1823";
                            break;
                        case 4:
                            kerdes = "4. kérdés: hány játékos van egy focicsapatban?";
                            helyesValasz = "11";
                            break;
                        case 5:
                            kerdes = "5. kérdés: Mi Franciaország fővárosa??";
                            helyesValasz = "Párizs";
                            break;
                        case 6:
                            kerdes = "6. kérdés: Melyik bolygó van legközelebb a Naphoz?";
                            helyesValasz = "Merkúr";
                            break;
                    }

                    Console.WriteLine(kerdes);
                    Console.Write("Válaszod: ");
                    string valasz = Console.ReadLine();

                    while (valasz != helyesValasz)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nem jó a válasz! Válaszolj a büntetőkérdésre!");
                        Console.ResetColor();
                       
                        string buntetoKerdes = "";
                        string buntetoHelyesValasz = "";

                        switch (dobas)
                        {
                            case 1:
                                buntetoKerdes = "1. büntetőkérdés: Mennyi 58 + 92?";
                                buntetoHelyesValasz = "150";
                                break;
                            case 2:
                                buntetoKerdes = "2. büntetőkérdés: Mikor volt a mohácsi csata?";
                                buntetoHelyesValasz = "1526";
                                break;
                            case 3:
                                buntetoKerdes = "3. büntetőkérdés: Ki írta a Szózatot?";
                                buntetoHelyesValasz = "Vörösmarty Mihály";
                                break;
                            case 4:
                                buntetoKerdes = "4. büntetőkérdés: Mikor születtek meg a labdarúgás első hivatalos szabályai?";
                                buntetoHelyesValasz = "1863";
                                break;
                            case 5:
                                buntetoKerdes = "5. büntetőkérdés: Mi Uganda fővárosa??";
                                buntetoHelyesValasz = "Kampala";
                                break;
                            case 6:
                                buntetoKerdes = "6. büntetőkérdés: Melyik gázból van a legtöbb a Föld légkörében?";
                                buntetoHelyesValasz = "Nitrogén";
                                break;
                        }

                        string buntetoValasz = "";
                        while (buntetoValasz != buntetoHelyesValasz)
                        {
                            Console.WriteLine(buntetoKerdes);
                            Console.Write("Válaszod: ");
                            buntetoValasz = Console.ReadLine();

                            if (buntetoValasz != buntetoHelyesValasz)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ez sem jó, próbáld újra a büntetőkérdést!");
                                Console.ResetColor();
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Helyes büntetőválasz! Most próbáld meg újra az eredeti kérdést.");
                        Console.ResetColor();
                        Console.WriteLine(kerdes);
                        Console.Write("Válaszod: ");
                        valasz = Console.ReadLine();
                    }

                    joValasz = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Helyes válasz!");
                    Console.ResetColor();
                }

                szint = szint + 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Elérted a " + szint + ". szintet!");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gratulálok, végigjátszottad mind az 5 szintet!");
            Console.ResetColor();
            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez!");
            Console.ReadKey(true);
        }
    }
}
