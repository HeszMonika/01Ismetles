using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ismetles
{
    class Program
    {
        static void Main()
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };//Felsoroljuk az elemeit és innen tudjuk , hány elemű.

            int gepValasz = vel.Next(0, 3 );//Választ egy random számot 0-2-ig.

            //Console.WriteLine("Gép választása: {0}", lehetoseg[gepValasz]);

            int jatekosValasz;

            Console.WriteLine("Kő (0), Papír (1), Olló (2)");
            Console.Write("Válassz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosValasz]);

            if (jatekosValasz == gepValasz)//Döntetlen.
            {
                Console.WriteLine("Döntetlen.");
            }
            else if(
                (jatekosValasz == 0 && gepValasz == 1)
                ||
                (jatekosValasz == 1 && gepValasz == 2)
                ||
                (jatekosValasz == 2 && gepValasz == 0)
                )//Gép nyer.
            {
                Console.WriteLine("Gép nyer.");
            }
          
            else//Játékos nyer.
            {
                Console.WriteLine("Játékos nyer.");
            }

            Console.ReadKey();
        }
    }
}
