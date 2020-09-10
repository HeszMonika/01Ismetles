using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ismetles
{
    class Program
    {
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };//Felsoroljuk az elemeit és innen tudjuk , hány elemű.

        static int gepNyer = 0;
        static int jatekosNyer = 0;
        static int menet = 0;

        static int JatekosValasztas()
        {
            Console.WriteLine("Kő (0), Papír (1), Olló (2)");
            Console.Write("Válassz: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GepValasztas()
        {
            Random vel = new Random();
            return vel.Next(0, 3);//Választ egy random számot 0-2-ig.
        }

        static void EredmenyKiiras(int gep, int ember)
        {
            Console.WriteLine("Gép: {0} --- Játékos: {1}", lehetoseg[gep], lehetoseg[ember]);

            switch (EmberNyer(gep, ember))
            {
                case 0:
                    Console.WriteLine("Döntetlen.");
                    break;
                case 1:
                    Console.WriteLine("Gép nyert.");
                    break;
                case 2:
                    Console.WriteLine("Játékos nyert.");
                    break;
            }
        }

        static int EmberNyer(int gep, int ember)
        {
            if (ember == gep)//Döntetlen.
            {
                return 0;
            }
            else if (
                (ember == 0 && gep == 1)
                ||
                (ember == 1 && gep == 2)
                ||
                (ember == 2 && gep == 0)
                )//Gép nyer.
            {
                gepNyer++;
                return 1;
            }

            else//Játékos nyer.
            {
                jatekosNyer++;
                return 2;
            }
        }

        private static bool AkarJatszani()
        {
            Console.WriteLine("\n----------------");
            Console.Write("Tovább? [i/n]: ");
            string valasz = Console.ReadLine().ToLower();
            Console.WriteLine("\n----------------");
            if (valasz == "i")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            //Console.WriteLine("Gép választása: {0}", lehetoseg[gep]);

            //Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosValasz]);

            bool tovabb = true;

            while (tovabb)
            {
                menet++;

                int gepValasz = GepValasztas();

                int jatekosValasz = JatekosValasztas();

                EredmenyKiiras(gepValasz, jatekosValasz);

                tovabb = AkarJatszani();
            }

            StatisztikaKiiras();

            Console.ReadKey();
        }

        private static void StatisztikaKiiras()
        {
            Console.WriteLine("Menetek száma:{0} Játékos győzelmének száma:{1} Gép győzelmének száma:{2} ", menet, jatekosNyer, gepNyer);
        }
    }
}
