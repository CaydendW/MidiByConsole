//This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
//Please credit me at this URL: https://github.com/CaydendW/

using System;

namespace TextEditor
{
    class Program
    {
        public static bool isForbiddenKey(ConsoleKey key)
        {
            ConsoleKey[] forbiddenKeys = { ConsoleKey.Print, ConsoleKey.PrintScreen, ConsoleKey.Pause, ConsoleKey.Home, ConsoleKey.PageUp, ConsoleKey.PageDown, ConsoleKey.End, ConsoleKey.NumPad0, ConsoleKey.NumPad1, ConsoleKey.NumPad2, ConsoleKey.NumPad3, ConsoleKey.NumPad4, ConsoleKey.NumPad5, ConsoleKey.NumPad6, ConsoleKey.NumPad7, ConsoleKey.NumPad8, ConsoleKey.NumPad9, ConsoleKey.Insert, ConsoleKey.F1, ConsoleKey.F2, ConsoleKey.F3, ConsoleKey.F4, ConsoleKey.F5, ConsoleKey.F6, ConsoleKey.F7, ConsoleKey.F8, ConsoleKey.F9, ConsoleKey.F10, ConsoleKey.F11, ConsoleKey.F12, ConsoleKey.Add, ConsoleKey.Divide, ConsoleKey.Multiply, ConsoleKey.Subtract, ConsoleKey.LeftWindows, ConsoleKey.RightWindows };
            for (int i = 0; i < forbiddenKeys.Length; i++)
            {
                if (key == forbiddenKeys[i]) return true;
            }
            return false;
        }

        public static void homescreenforcanvas()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Welcome to painting in console!");
            Console.WriteLine("");
            Console.WriteLine("Use your arrow keys to move the cursor");
            Console.WriteLine("Everything is written left of the cursor");
            Console.WriteLine("use w, a, s and d to move the cursor without painting");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press 1 for red");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press 2 for cyan");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press 3 for yellow");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("press 4 for green");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("press 5 for blue");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("press 6 for pink");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("press 7 for purple");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("press 8 for black");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("press 9 for white");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("press 0 for gray");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Press Esc (Escape) to exit");
            Console.WriteLine("Press Tab to get help (This resets your progress)");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue into the canvas");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(1, 0);
        }
        static void Main(string[] args)
        {
            homescreenforcanvas();

            ConsoleKeyInfo info;

            while (true)
            {
                try
                {
                    info = Console.ReadKey(true);

                    if (info.Key == ConsoleKey.W)
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    }
                    else if (info.Key == ConsoleKey.S)
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                    }
                    else if (info.Key == ConsoleKey.A)
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                    else if (info.Key == ConsoleKey.D)
                    {
                        Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                    }

                    else if (info.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                        Console.Write(" ");
                    }
                    else if (info.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                        Console.Write(" ");
                    }
                    else if (info.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        Console.Write(" ");
                    }
                    else if (info.Key == ConsoleKey.RightArrow)
                    {
                        Console.Write(" ");
                    }

                    else if (info.Key == ConsoleKey.D1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else if (info.Key == ConsoleKey.D2)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                    }
                    else if (info.Key == ConsoleKey.D3)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    else if (info.Key == ConsoleKey.D4)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (info.Key == ConsoleKey.D5)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (info.Key == ConsoleKey.D6)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    else if (info.Key == ConsoleKey.D7)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    }
                    else if (info.Key == ConsoleKey.D8)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (info.Key == ConsoleKey.D9)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (info.Key == ConsoleKey.D0)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else if (info.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (info.Key == ConsoleKey.Tab)
                    {
                        homescreenforcanvas();
                    }
                    else
                    {
                        if (isForbiddenKey(info.Key))
                        {
                            ;
                        }
                        else
                        {
                            
                        }
                    }
                }
                catch
                {

                }
            }
        }
    }
}