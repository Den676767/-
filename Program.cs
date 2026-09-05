using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("HelloWOrld");
            //Console.ReadKey();
            //byte b;
           // sbyte sb;
            //short s;
            //ushort us;
            //int q; // легенда
            //uint ui;
           // double d;
            //float f = 5.7f; // основной 
            //char c = ' ';// основной
            //string str = "string"; // основной
            //bool bl; // основной

            //result = Convert.ToSingle(x / y); для вывода с точкой 
            //string message = name +'омлет' + age;
            //Console.WriteLine(name + ', привет, рад тебя видеть ');
            // cw + tab = write
            //Console.WriteLine($"имя { name} вам {age} лет);
           // Console.Write("");
            Random rand = new Random();
            float health = rand.Next(90, 100);
            int DAMAGE  = rand.Next(5, 20);
            int ARMOR  = rand.Next(25, 65);
            float health2 = rand.Next(80, 150);
            int damage2 = rand.Next(20, 40);
            int armor2  = rand.Next(65, 100);
            while (health > 0 && health2 > 0) 
            {
                health -= Convert.ToSingle (rand.Next(0,damage2 + 1)) / 100 * ARMOR;
                health -= Convert.ToSingle (rand.Next(0,DAMAGE + 1)) / 100 * armor2;
                Console.WriteLine("здоровье 1 " +health);
                Console.WriteLine("здоровье 2 " + health2);
            }
            if (health <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья");
            }
            else if(health <= 0)
            {
                Console.WriteLine("1 проиграл");
            }
            else if(health2 <= 0)
            {
                Console.WriteLine("2 проиграл");
            }
            // /b - удалить символ
            /*Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WindowHeight = 10;
            Console.WindowWidth = 10;
            Console.Clear();*/
            Console.CursorVisible = false;
            char[,] map =
            {
                 { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'  },
                 { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'  },
                 { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'  },
                 { '#', ' ', '#', ' ', ' ', ' ', 'x', 'x', '#', ' ', ' ', ' ', '#'  },
                 { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', 'x', '#'  },
                 { '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#', '#', 'x', '#'  },
                 { '#', ' ', ' ', ' ', ' ', ' ', ' ', 'x', ' ', ' ', '#', ' ', '#'  },
                 { '#', ' ', 'x', 'x', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'  },
                 { '#', ' ', ' ', 'x',  ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'  },
                 { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'  },
                 { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'  }
            };
            int userx=6, usery = 6;
            char[] bag = new char[1];
            while (true)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("Сумма:");
                for(int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(usery, userx);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch(charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userx-1,usery] != '#')
                        {
                            userx--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userx + 1, usery] != '#'){
                            userx++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userx, usery-1] != '#'){
                            usery--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userx, usery + 1] != '#')
                        {
                            usery++;
                        }
                        break;
                }
                if (map[userx,usery] == 'x')
                {
                    map[userx, usery] = 'o';
                    char[] tampBag = new char[bag.Length + 1];
                    for(int i = 0; i < bag.Length; i++)
                    {
                        tampBag[i] = bag[i];
                    }
                    tampBag[tampBag.Length - 1] = 'X';
                    bag = tampBag;
                }
                Console.Clear();
            }

























        }
    }
}
