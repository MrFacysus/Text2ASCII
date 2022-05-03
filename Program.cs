using System;
using System.Collections.Generic;
using System.Linq;

namespace Text2ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz? ";
            string ASCII = " #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ###     \n# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   #     \n### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ##     \n# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #           \n# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #      ";
            string ipt = Console.ReadLine();

            int debugx = 0;
            int debugi = 0;

            List<string> Lines = ASCII.Split('\n').ToList();

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 5; i++)
            {
                string Line = "";
                foreach (char c in ipt)
                {
                    if (alphabet.Contains(char.ToLower(c)))
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            Line += Lines[i][alphabet.IndexOf(char.ToLower(c)) * 4 + x];
                        }
                    }
                }
                Console.WriteLine(Line);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
