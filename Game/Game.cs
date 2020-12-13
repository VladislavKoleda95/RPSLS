using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Game
{
    class Game
    {
        public static void RPCLS(int playermove, int computermove, string[] args)
        {
            if (args.Length == 3)
            {
                if (playermove == computermove)
                {
                    Console.WriteLine("Ничья");
                }
                else if (playermove == 0 && computermove == 1)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if (playermove == 1 && computermove == 2)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if (playermove == 2 && computermove == 0)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if (playermove == 0 && computermove == 2)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 1 && computermove == 0)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 2 && computermove == 1)
                {
                    Console.WriteLine("Победил компьютер");
                }
            }
            if (args.Length == 5)
            {
                if (playermove == computermove)
                {
                    Console.WriteLine("Ничья");
                }

                if (playermove == 0 && computermove == 1 || playermove == 0 && computermove == 2)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if (playermove == 1 && computermove == 2 || playermove == 1 && computermove == 3)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if (playermove == 2 && computermove == 3 || playermove == 2 && computermove == 4)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if (playermove == 3 && computermove == 4 || playermove == 4 && computermove == 0)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if (playermove == 4 && computermove == 0 || playermove == 4 && computermove == 1)
                {
                    Console.WriteLine("Победил игрок");
                }

                else if (playermove == 0 && computermove == 3 || playermove == 0 && computermove == 4)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 1 && computermove == 4 || playermove == 2 && computermove == 0)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 2 && computermove == 0 || playermove == 2 && computermove == 1)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 3 && computermove == 1 || playermove == 4 && computermove == 2)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 4 && computermove == 3 || playermove == 4 && computermove == 4)
                {
                    Console.WriteLine("Победил компьютер");
                }
                if (args.Length == 7)
                {
                    if (playermove == computermove)
                    {
                        Console.WriteLine("Ничья");
                    }

                    int g = computermove - playermove % 5;
                    Console.WriteLine(g);

                }
            }
            if (args.Length == 7)
            {
                if (playermove == computermove)
                {
                    Console.WriteLine("Ничья");
                }

                if ((playermove == 0 && computermove == 1) || (playermove == 0 && computermove == 2) || (playermove == 0 && computermove == 3))
                {
                    Console.WriteLine("Победил игрок");
                }
                else if ((playermove == 1 && computermove == 2) || (playermove == 1 && computermove == 3) || (playermove == 1 && computermove == 4))
                {
                    Console.WriteLine("Победил игрок");
                }
                else if ((playermove == 2 && computermove == 3) || (playermove == 2 && computermove == 4) || playermove == 2 && computermove == 5)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if ((playermove == 3 && computermove == 4) || (playermove == 3 && computermove == 5) || playermove == 3 && computermove == 6)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if ((playermove == 4 && computermove == 5) || (playermove == 4 && computermove == 6) || playermove == 4 && computermove == 0)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if ((playermove == 5 && computermove == 6) || (playermove == 5 && computermove == 0) || playermove == 5 && computermove == 1)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if ((playermove == 6 && computermove == 0) || (playermove == 6 && computermove == 1) || playermove == 6 && computermove == 2)
                {
                    Console.WriteLine("Победил игрок");
                }
                else if ((playermove == 0 && computermove == 4) || (playermove == 0 && computermove == 5) || playermove == 0 && computermove == 6)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 1 && computermove == 5 || playermove == 1 && computermove == 6 || playermove == 1 && computermove == 0)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 2 && computermove == 6 || playermove == 2 && computermove == 0 || playermove == 2 && computermove == 1)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 3 && computermove == 0 || playermove == 3 && computermove == 1 || playermove == 3 && computermove == 2)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 4 && computermove == 1 || playermove == 4 && computermove == 2 || playermove == 4 && computermove == 3)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 5 && computermove == 2 || playermove == 5 && computermove == 3 || playermove == 5 && computermove == 4)
                {
                    Console.WriteLine("Победил компьютер");
                }
                else if (playermove == 6 && computermove == 3 || playermove == 6 && computermove == 4 || playermove == 6 && computermove == 5)
                {
                    Console.WriteLine("Победил компьютер");
                }
            }
        }
    }
}