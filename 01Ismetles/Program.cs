﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ismetles
{
    class Program
    {
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };//Felsoroljuk az elemeit és innen tudjuk , hány elemű.

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
                return 1;
            }

            else//Játékos nyer.
            {
                return 2;
            }
        }

        static void Main()
        {
            int gepValasz = GepValasztas();

            //Console.WriteLine("Gép választása: {0}", lehetoseg[gep]);

            int jatekosValasz = JatekosValasztas();
            
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosValasz]);

            EredmenyKiiras(gepValasz, jatekosValasz);

            Console.ReadKey();
        }
    }
}
