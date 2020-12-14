using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Arguments
    {
        public static void ArgumentCheck(string[] args)
        {
            int matches = 0;

            for (int i = 0; i < args.Length; i++)
            {
                for (int j = i + 1; j < args.Length; j++)
                {
                    if (args[i] == args[j])
                    {
                        matches++;
                        break;
                    }
                }
            }

            if (args.Length < 3 || args.Length > 7 || args.Length == 1 || args.Length ==0)
            {
                Console.WriteLine("Количество аргументов должно быть в пределах от 3 до 7");
                Console.WriteLine("Пример: " + System.IO.Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location) +
                    " \"rock\" \"paper\" \"scissors\"");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else if (args.Length % 2 == 0)
            {
                Console.WriteLine("Количество аргументов должно быть нечетным");
                Process.GetCurrentProcess().Kill();
            }
            else if (matches > 0)
            {
                Console.WriteLine("Аргументы не должны повторяться");
                Process.GetCurrentProcess().Kill();

            }

        }
    }
}
