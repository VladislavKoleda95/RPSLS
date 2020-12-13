using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Game
{
    class Messages
    {
        public static void AvailableMoves(string[] str)
        {
            if (str.Length == 3)
            {
                Console.WriteLine("Available moves:");
                Console.WriteLine("1 - " + str[0]);
                Console.WriteLine("2 - " + str[1]);
                Console.WriteLine("3 - " + str[2]);
                Console.WriteLine("0 - Exit");
            }
            else if (str.Length == 5)
            {
                Console.WriteLine("Available moves:");
                Console.WriteLine("1 - " + str[0]);
                Console.WriteLine("2 - " + str[1]);
                Console.WriteLine("3 - " + str[2]);
                Console.WriteLine("4 - " + str[3]);
                Console.WriteLine("5 - " + str[4]);
                Console.WriteLine("0 - Exit");
            }
            else if (str.Length == 7)
            {
                Console.WriteLine("Available moves:");
                Console.WriteLine("1 - " + str[0]);
                Console.WriteLine("2 - " + str[1]);
                Console.WriteLine("3 - " + str[2]);
                Console.WriteLine("4 - " + str[3]);
                Console.WriteLine("5 - " + str[4]);
                Console.WriteLine("6 - " + str[5]);
                Console.WriteLine("7 - " + str[6]);
                Console.WriteLine("0 - Exit");
            }
        }
    }
}
