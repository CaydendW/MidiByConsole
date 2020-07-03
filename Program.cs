//This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
//Please credit me at this URL: https://github.com/CaydendW/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        public static string toplay = "";

        static void Main(string[] args)
        {
            int hcs = 1108;
            int hc = 1046;
            int hb = 987;
            int hbf = 932;
            int ha = 880;
            int hgs = 830;
            int hg = 783;
            int hfs = 739;
            int hf = 698;
            int he = 659;
            int hef = 622;
            int hd = 587;

            int lcs = 554;
            int lc = 523;
            int lb = 493;
            int lbf = 466;
            int la = 440;
            int lgs = 415;
            int lg = 391;
            int lfs = 370;
            int lf = 349;
            int le = 329;
            int lef = 311;
            int ld = 293;

            string fromcon = Console.ReadLine().ToString();
            string[] sep = fromcon.Split(" ");
            int i = 0;
            while (i != fromcon.Length - 1)
            {
                try
                {
                    string input = sep[i];
                    string dur2 = input.Substring(input.LastIndexOf('-') + 1);
                    int dur = int.Parse(dur2);
                    string toplay = input.Split('-')[0];

                    if (toplay == "a")
                    {
                        Console.Beep(la, dur);
                    }
                    else if (toplay == "b")
                    {
                        Console.Beep(lb, dur);
                    }
                    else if (toplay == "c")
                    {
                        Console.Beep(lc, dur);
                    }
                    else if (toplay == "d")
                    {
                        Console.Beep(ld, dur);
                    }
                    else if (toplay == "e")
                    {
                        Console.Beep(le, dur);
                    }
                    else if (toplay == "f")
                    {
                        Console.Beep(lf, dur);
                    }
                    else if (toplay == "g")
                    {
                        Console.Beep(lg, dur);
                    }
                    // specials
                    else if (toplay == "(c)")
                    {
                        Console.Beep(lcs, dur);
                    }
                    else if (toplay == "(b)")
                    {
                        Console.Beep(lbf, dur);
                    }
                    else if (toplay == "(g)")
                    {
                        Console.Beep(lgs, dur);
                    }
                    else if (toplay == "(f)")
                    {
                        Console.Beep(lfs, dur);
                    }
                    else if (toplay == "(e)")
                    {
                        Console.Beep(lef, dur);
                    }

                    //new octave//

                    else if (toplay == "A")
                    {
                        Console.Beep(ha, dur);
                    }
                    else if (toplay == "B")
                    {
                        Console.Beep(hb, dur);
                    }
                    else if (toplay == "C")
                    {
                        Console.Beep(hc, dur);
                    }
                    else if (toplay == "D")
                    {
                        Console.Beep(hd, dur);
                    }
                    else if (toplay == "E")
                    {
                        Console.Beep(he, dur);
                    }
                    else if (toplay == "F")
                    {
                        Console.Beep(hf, dur);
                    }
                    else if (toplay == "G")
                    {
                        Console.Beep(hg, dur);
                    }
                    else if (toplay == "r")
                    {
                        Thread.Sleep(dur);
                    }
                    else if (toplay == "R")
                    {
                        Thread.Sleep(dur);
                    }
                    //specials
                    else if (toplay == "(C)")
                    {
                        Console.Beep(hcs, dur);
                    }
                    else if (toplay == "(B)")
                    {
                        Console.Beep(hbf, dur);
                    }
                    else if (toplay == "(G)")
                    {
                        Console.Beep(hgs, dur);
                    }
                    else if (toplay == "(F)")
                    {
                        Console.Beep(hfs, dur);
                    }
                    else if (toplay == "(E)")
                    {
                        Console.Beep(hef, dur);
                    }
                    i++;
                }
                catch (IndexOutOfRangeException) { break; }
            }
        }
    }
}
