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
            if (playermove > computermove)
            {
                if (playermove - computermove <= (args.Length - 1) / 2)
                {
                    Console.WriteLine("Выиграл компьютер");
                }
                else
                {
                    Console.WriteLine("Выиграл игрок");
                }
            }
            else if (playermove < computermove)
            {
                if (computermove - playermove <= (args.Length - 1) / 2)
                {
                    Console.WriteLine("Выиграл игрок");
                }
                else
                {
                    Console.WriteLine("Выиграл компьютер");
                }
            }
            else
            {
                Console.WriteLine("Ничья");
            }
        }
    }
}