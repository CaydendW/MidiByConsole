using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Drawing;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class Program
    {
        public static string toplay = "";
        public static string r1 = "";
        public static string tim1 = "";
        public static string oct1 = "";

        public static Random random = new Random();

        public static string getnot(string r, string tim, string oct)
        {
            string[] notchars = { };
            string[] timesig = { };

            string[] fullnotchars = { "a", "b", "c", "d", "e", "f", "g", "(c)", "(b)", "(g)", "(f)", "(e)", "A", "B", "C", "D", "E", "F", "G", "(C)", "(B)", "(G)", "(F)", "(E)", "[a]", "[b]", "[c]", "[d]", "[e]", "[f]", "[g]", "([c])", "([b])", "([g])", "([f])", "([e])", "_" };
            string[] lowernotchars = { "[a]", "[b]", "[c]", "[d]", "[e]", "[f]", "[g]", "[g]", "([c])", "([b])", "([g])", "([f])", "([e])", "_" };
            string[] midnotchars = { "a", "b", "c", "d", "e", "f", "g", "(c)", "(b)", "(g)", "(f)", "(e)", "_" };
            string[] highnotchars = { "A", "B", "C", "D", "E", "F", "G", "(C)", "(B)", "(G)", "(F)", "(E)", "_" };
            string[] norfullnotchars = { "a", "b", "c", "d", "e", "f", "g", "A", "B", "C", "D", "E", "F", "G", "[a]", "[b]", "[c]", "[d]", "[e]", "[f]", "[g]" };
            string[] norlowernotchars = { "[a]", "[b]", "[c]", "[d]", "[e]", "[f]", "[g]", "[g]", "([c])", "([b])", "([g])", "([f])", "([e])" };
            string[] normidnotchars = { "a", "b", "c", "d", "e", "f" , "(c)", "(b)", "(g)", "(f)", "(e)" };
            string[] norhighnotchars = { "A", "B", "C", "D", "E", "F", "G", "(C)", "(B)", "(G)", "(F)", "(E)" };

            string[] fftiming = { "1000", "500", "250", "125", "63" };
            string[] setiming = { "999", "333", "111", "37" };

            if (r == "y")
            {
                if (oct == "1") { notchars = fullnotchars; }
                else if (oct == "2") { notchars = lowernotchars; }
                else if (oct == "3") { notchars = midnotchars; }
                else if (oct == "4") { notchars = highnotchars; }
                else { Environment.Exit(0); }
            }
            else if (r == "n")
            {
                if (oct == "1") { notchars = norfullnotchars; }
                else if (oct == "2") { notchars = norlowernotchars; }
                else if (oct == "3") { notchars = normidnotchars; }
                else if (oct == "4") { notchars = norhighnotchars; }
                else { Environment.Exit(0); }
            }
            else { Environment.Exit(0); }

            if (tim == "1") { timesig = fftiming; }
            else if (tim == "2") { timesig = setiming; }
            else { Environment.Exit(0); }

            int a = random.Next(notchars.Length);
            string not = notchars[a];

            int b = random.Next(timesig.Length);
            string len = timesig[b];

            return not + "-" + len;
        }

        static void Main(string[] args)
        {
            int rif = 0;

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

            int vlcs = 277;
            int vlc = 261;
            int vlb = 246;
            int vlbf = 233;
            int vla = 220;
            int vlgs = 207;
            int vlg = 195;
            int vlf = 174;
            int vlfs = 185;
            int vle = 165;
            int vlef = 155;
            int vld = 146;

            string fromcon = " ";
            string[] sep = { };
            int timetoloop = 0;

            Console.Write("Would you like to read a [f]ile, play [r]andom music or [w]rite a song in the command line: ");
            string howtoplay = Console.ReadLine();

            if (howtoplay == "w")
            {
                Console.Write("Type your melody in here: ");
                fromcon = Console.ReadLine();
                sep = fromcon.Split(" ");
                timetoloop = fromcon.Length;
            }
            else if (howtoplay == "f")
            {
                Console.Write("What file do you want to play: ");
                string fille = Console.ReadLine().Replace("\"", "");
                if (File.Exists(fille))
                {
                    fromcon = File.ReadAllText(fille);
                    fromcon = fromcon.Replace("\r\n", " ");
                }
                else
                {
                    Console.WriteLine("This file does not exist!");
                }
                sep = fromcon.Split(" ");
                timetoloop = fromcon.Length;
            }
            else if (howtoplay == "r")
            {
                Console.Write(@"Do you want rests Y/N: ");
                r1 = Console.ReadLine().ToLower();

                Console.Write("Choose your time signature: \n1) 4/4\n2) 6/8\n\nMake your choice: ");
                tim1 = Console.ReadLine();

                Console.Write("Choose your octave:\n1) Full range\n2) Lower notes\n3) Mid notes\n4) Higher notes\n\nMake your choice: ");
                oct1 = Console.ReadLine().ToLower();

                timetoloop = 999999;

                rif = 1;
            }

            int i = 0;
            while (i != timetoloop)
            {
                try
                {
                    int dur = 0;
                    string toplay = "";

                    if (rif ==-0)
                    {
                        string input = sep[i];
                        string dur2 = input.Substring(input.LastIndexOf('-') + 1);
                        dur = int.Parse(dur2);
                        toplay = input.Split('-')[0];
                    }
                    else if (rif == 1)
                    {
                        string input = getnot(r1, tim1, oct1);
                        string dur2 = input.Substring(input.LastIndexOf('-') + 1);
                        dur = int.Parse(dur2);
                        toplay = input.Split('-')[0];
                    }

                    //
                    // very low ocatave
                    //
                    if (toplay == "[a]")
                    {
                        Console.Beep(vla, dur);
                    }
                    else if (toplay == "[b]")
                    {
                        Console.Beep(vlb, dur);
                    }
                    else if (toplay == "[c]")
                    {
                        Console.Beep(vlc, dur);
                    }
                    else if (toplay == "[d]")
                    {
                        Console.Beep(vld, dur);
                    }
                    else if (toplay == "[e]")
                    {
                        Console.Beep(vle, dur);
                    }
                    else if (toplay == "[f]")
                    {
                        Console.Beep(vlf, dur);
                    }
                    else if (toplay == "[g]")
                    {
                        Console.Beep(vlg, dur);
                    }
                    // special notes
                    else if (toplay == "([c])")
                    {
                        Console.Beep(vlcs, dur);
                    }
                    else if (toplay == "([b])")
                    {
                        Console.Beep(vlbf, dur);
                    }
                    else if (toplay == "([g])")
                    {
                        Console.Beep(vlgs, dur);
                    }
                    else if (toplay == "([f])")
                    {
                        Console.Beep(vlfs, dur);
                    }
                    else if (toplay == "([e])")
                    {
                        Console.Beep(vlef, dur);
                    }

                    //
                    //low ocatave//
                    //

                    else if (toplay == "a")
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
                    // specials //
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

                    //
                    //high octave//
                    //

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
                    //specials//
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

                    //rest
                    else if (toplay == "_")
                    {
                        Thread.Sleep(dur);
                    }

                    else if (toplay == "end;")
                    {
                        break;
                    }

                    //wrong char
                    else
                    {
                        Console.WriteLine(toplay = " is not a valid character!");
                        Console.ReadKey();
                        break;
                    }
                    i++;
                }
                catch (IndexOutOfRangeException) { break; }
            }
        }
    }
}