using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public static class Message
    {
        public static void SetStartPosition()
        {
            Console.SetCursorPosition(0,17);
        }
        public static void ShowStats(Character character)
        {
            string name = character.Name;
            int lvl = character.Level, hp = (int)character.Hp, maxHp = (int)character.MaxHp, mp = (int)character.Mp, maxMp = (int)character.MaxMp, gold = character.Gold;
            Console.WriteLine("                                                           ");
            if (name == "-")
            {
                int left = Console.CursorLeft;
                int top = Console.CursorTop;
                Console.SetCursorPosition(0, 0);

                Write("No info");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("**************************************************");

                Console.SetCursorPosition(left, top);
            }
            else
            {
                int left = Console.CursorLeft;
                int top = Console.CursorTop;
                Console.SetCursorPosition(0, 0);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Name:" + name + " Lvl:" + lvl);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Hp:" + hp + "/" + maxHp);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Mp:" + mp + "/" + maxMp);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Gold:" + gold);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("**************************************************");

                Console.SetCursorPosition(left, top);
            }
        }
        public static void ShowAction(string text)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(0,2);

            Console.CursorSize = 100;
            Console.Write("                                                                   ");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(text);
            Console.Write("**************************************************");
            Console.SetCursorPosition(left, top);
        }
        public static void ShowWarning(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(0, 2);

            Console.CursorSize = 100;
            Console.Write("                                                                   ");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("**************************************************");
            Console.SetCursorPosition(left, top);
        }
        public static void ShowEnemyStats(Character character)
        {
            if (character != null)
            {
                string name = character.Name;
                int lvl = character.Level, hp = (int)character.Hp, maxHp = (int)character.MaxHp, mp = (int)character.Mp, maxMp = (int)character.MaxMp;
                if (name == "-")
                {
                    int left = Console.CursorLeft;
                    int top = Console.CursorTop;
                    Console.SetCursorPosition(0, 5);

                    Write("No info");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("**************************************************");

                    Console.SetCursorPosition(left, top);
                }
                else
                {
                    int left = Console.CursorLeft;
                    int top = Console.CursorTop;
                    Console.SetCursorPosition(0, 4);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Name:" + name + " Lvl:" + lvl);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Hp:" + hp + "/" + maxHp);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Mp:" + mp + "/" + maxMp);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("**************************************************");

                    Console.SetCursorPosition(left, top);
                }
            }
            else
            {
                int left = Console.CursorLeft;
                int top = Console.CursorTop;
                Console.SetCursorPosition(0, 4);

                WriteLine("No info");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("**************************************************");

                Console.SetCursorPosition(left, top);
            }
        }
        public static void DrawImage(List<string> image)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(0, 6);
            foreach (var i in image)
            {
                WriteLine(i);
            }
            Console.SetCursorPosition(left, top);
        }
        public static void CloseLine()
        {
            Console.SetCursorPosition(0, 16);
            Console.Write("**************************************************");
            Console.SetCursorPosition(0, 18);
            Console.Write("**************************************************");
        }
        public static void Write(string text)
        {
            Console.Write(text);
        }
        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
        public static string ReadLine()
        {
            SetStartPosition();
            Write("                          ");
            SetStartPosition();
            string text = Console.ReadLine();
            return text;
        }
    }
}
