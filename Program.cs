using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RPSLS
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Arguments.ArgumentCheck(args);

            int playermove = default;

            Random random = new Random();

            for(int i =0; i < args.Length; i++)
            {
                int computermove = random.Next(0, args.Length -1);

                string input = args[computermove];

                byte[] secretkey = new byte[16];

                RandomNumberGenerator rndgenerator = RandomNumberGenerator.Create();

                rndgenerator.GetBytes(secretkey);

                byte[] SecretKey = Encoding.ASCII.GetBytes(HMAC.ByteToString(secretkey));

                Console.WriteLine("Hash " + HMAC.Encode(input, SecretKey));
              
                do
                {
                    Game.Messages.AvailableMoves(args);

                    Console.WriteLine("Enter your move:");

                    playermove = Game.ChoiceMove.Move(args);

                    Game.Game.RPCLS(playermove, computermove, args);

                    Console.WriteLine("Your move: " + args[playermove]);

                    Console.WriteLine("Computer move:" + input + "\n");

                    Game.Game.RPCLS(playermove, computermove, args);

                    Console.WriteLine("HMAC Key " + HMAC.ByteToString(secretkey) + "\n");

                } while (playermove > 0 && playermove < 7);

            }


            
        }
    }
}