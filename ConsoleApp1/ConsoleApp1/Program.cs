using System;

namespace Kasa
{
    public class Program
    {
        public struct Artykul
        {
            public string nazwa;
            public double cenaSztuka;
        }

        private static void Main(string[] args)
        {
            Artykul Chleb;
            Artykul Maslo;
            Artykul Makaron;
            Artykul Dzem;
            Artykul Kielbasa;
            Artykul Szynka;
            Artykul Chipsy;
            Artykul Serek_wiejski;
            Artykul Sol_kuchenna;
            Artykul Cukier_krysztal;

            Chleb.nazwa = "Chleb wiejski";
            Chleb.cenaSztuka = 4.50;

            Maslo.nazwa = "Maslo extra";
            Maslo.cenaSztuka = 6.50;

            Makaron.nazwa = "Makaron babuni";
            Makaron.cenaSztuka = 9.20;

            Dzem.nazwa = "Dzem truskawkowy";
            Dzem.cenaSztuka = 8.10;

            Kielbasa.nazwa = "Kielbasa mysliwska";
            Kielbasa.cenaSztuka = 29.00;

            Szynka.nazwa = "Szynka konserwowa";
            Szynka.cenaSztuka = 22.00;

            Chipsy.nazwa = "Chipsy paprykowe";
            Chipsy.cenaSztuka = 6.00;

            Serek_wiejski.nazwa = "Serek Wiejski";
            Serek_wiejski.cenaSztuka = 3.50;

            Sol_kuchenna.nazwa = "Sol kuchenna";
            Sol_kuchenna.cenaSztuka = 2.70;

            Cukier_krysztal.nazwa = "Cukier kryształ";
            Cukier_krysztal.cenaSztuka = 3.20;



            string wyswietl()
            {
                Console.WriteLine(
                              $"\n   " +
                              $"[001]     {Chleb.nazwa} {Chleb.cenaSztuka}zł\n   " +
                              $"[002]     {Maslo.nazwa} {Maslo.cenaSztuka}zł\n   " +
                              $"[003]     {Makaron.nazwa} {Makaron.cenaSztuka}zł\n   " +
                              $"[004]     {Dzem.nazwa} {Dzem.cenaSztuka}zł\n   " +
                              $"[005]     {Kielbasa.nazwa} {Kielbasa.cenaSztuka}zł\n   " +
                              $"[006]     {Szynka.nazwa} {Szynka.cenaSztuka}zł\n   " +
                              $"[007]     {Chipsy.nazwa} {Chipsy.cenaSztuka}zł\n   " +
                              $"[008]     {Serek_wiejski.nazwa} {Serek_wiejski.cenaSztuka}zł\n   " +
                              $"[009]     {Sol_kuchenna.nazwa} {Sol_kuchenna.cenaSztuka}zł\n   " +
                              $"[010]     {Cukier_krysztal.nazwa} {Cukier_krysztal.cenaSztuka}zł\n   ");
            return "";
            }

            Console.WriteLine("-- Kasa sklepowa -- \n\nProszę wybrać artykuł: \n");

            int szt = 0;
            int szt2 = 0;
            int szt3 = 0;
            int szt4 = 0;
            int szt5 = 0;
            int szt6 = 0;
            int szt7 = 0;
            int szt8 = 0;
            int szt9 = 0;
            int szt10 = 0;

            wybor();

            void wybor()
            {
                Console.WriteLine(wyswietl());
                var operation = Console.ReadLine();
                switch (operation)
                {
                    case "001":
                        Console.Clear();
                        Console.WriteLine("Ile sztuk?");
                        szt = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt);
                        kontynuacja();
                        break;

                    case "002":
                        Console.WriteLine("Ile sztuk?");
                        szt2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt2);
                        kontynuacja();
                        break;

                    case "003":
                        Console.WriteLine("Ile sztuk?");
                        szt3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt3);
                        kontynuacja();
                        break;

                    case "004":
                        Console.WriteLine("Ile sztuk?");
                        szt4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt4);
                        kontynuacja();
                        break;

                    case "005":
                        Console.WriteLine("Ile sztuk?");
                        szt5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt5);
                        kontynuacja();
                        break;

                    case "006":
                        Console.WriteLine("Ile sztuk?");
                        szt6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt6);
                        kontynuacja();
                        break;

                    case "007":
                        Console.WriteLine("Ile sztuk?");
                        szt7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt7);
                        kontynuacja();
                        break;

                    case "008":
                        Console.WriteLine("Ile sztuk?");
                        szt8 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt8);
                        kontynuacja();
                        break;

                    case "009":
                        Console.WriteLine("Ile sztuk?");
                        szt9 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt9);
                        kontynuacja();
                        break;

                    case "010":
                        Console.WriteLine("Ile sztuk?");
                        szt10 = int.Parse(Console.ReadLine());
                        Console.WriteLine("wybrano {0} szt", szt10);
                        kontynuacja();
                        break;

                    default:
                        throw new Exception("Wybrałeś zla operacje\n");
                }
            }
            string kontynuacja()
            {
                Console.WriteLine("1 - dalej \n  2 - zaplac");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        wybor();
                        break;

                    case 2:
                        Console.Clear();
                        zaplac();
                        Console.ReadKey();
                        break;
                }
                return "";
            }
            void zaplac()
            {
                double total;
                double w1 = Chleb.cenaSztuka * szt;
                double w2 = Maslo.cenaSztuka * szt2;
                double w3 = Makaron.cenaSztuka * szt3;
                double w4 = Dzem.cenaSztuka * szt4;
                double w5 = Kielbasa.cenaSztuka * szt5;
                double w6 = Szynka.cenaSztuka * szt6;
                double w7 = Chipsy.cenaSztuka * szt7;
                double w8 = Serek_wiejski.cenaSztuka * szt8;
                double w9 = Sol_kuchenna.cenaSztuka * szt9;
                double w10 = Cukier_krysztal.cenaSztuka * szt10;
                if (szt != 0 || szt2 != 0 || szt3 != 0 || szt4 != 0 || szt5 != 0 || szt6 != 0 || szt7 != 0 || szt8 != 0 || szt9 != 0 || szt10 != 0)
                {
                    total = w1 + w2 + w3 + w4 + w5 + w6 + w7 + w8 + w9 + w10;
                    Console.WriteLine("Łacznie do zapłaty: {0} zł", Math.Round(total, 2).ToString("00.00"));
                    Console.WriteLine("W tym VAT:  {0} zł", Math.Round(total *0.23, 2).ToString("00.00"));
                }
                else
                {
                    Console.WriteLine("blad");
                }
            }
        }
    }
}