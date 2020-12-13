using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Game
{
    class ChoiceMove
    {
        public static int Move(string[] str)
        {
            int index = default;

            int playermove = default;
            
            bool result = int.TryParse(Console.ReadLine(), out index);

            if (index == 0)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

            if (str.Length == 3)
            {
                switch (index)
                {
                    case 1:
                        playermove = 0;
                        break;
                    case 2:
                        playermove = 1;
                        break;
                    case 3:
                        playermove = 2;
                        break;
                }
            }
            else if (str.Length == 5)
            {
                switch (index)
                {
                    case 1:
                        playermove = 0;
                        break;
                    case 2:
                        playermove = 1;
                        break;
                    case 3:
                        playermove = 2;
                        break;
                    case 4:
                        playermove = 3;
                        break;
                    case 5:
                        playermove = 4;
                        break;
                }
            }
            else if (str.Length == 7)
            {
                switch (index)
                {
                    case 1:
                        playermove = 0;
                        break;
                    case 2:
                        playermove = 1;
                        break;
                    case 3:
                        playermove = 2;
                        break;
                    case 4:
                        playermove = 3;
                        break;
                    case 5:
                        playermove = 4;
                        break;
                    case 6:
                        playermove = 5;
                        break;
                    case 7:
                        playermove = 6;
                        break;
                }

            }

            return playermove;
        }
    }
}
