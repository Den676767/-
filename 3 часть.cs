using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double bigNum = num;

            double pi = 3.14159;
            int intPi = (int)pi;

            Console.WriteLine($"Неявное приведение int -> double: {bigNum}");
            Console.WriteLine($"Явное приведение double -> int (с потерей дроби): {intPi}");




            Player player = new Player();
            player.Health = 100;

            Entity entity = player;
            Console.WriteLine($"Upcasting выполнен успешно. HP сущности: {entity.Health}");

            Player originalPlayer = (Player)entity;
            originalPlayer.Mana = 50;
            Console.WriteLine($"Downcasting выполнен успешно. Мана игрока: {originalPlayer.Mana}");




            Entity someEntity = new Player();

            if (someEntity is Player)
            {
                Console.WriteLine("Проверка 'is': Объект является типом Player.");
            }

            Player p = someEntity as Player;
            if (p != null)
            {
                p.TakeDamage(25);
                Console.WriteLine($"Проверка 'as': Приведение прошло успешно. Оставшееся HP: {p.Health}");
            }




            object data = "Зелье здоровья (+50 HP)";

            if (data is string item)
            {
                Console.WriteLine($"Pattern Matching: Распознана строка — '{item}'");
            }

            object goldData = 500;
            if (goldData is int goldCoins)
            {
                Console.WriteLine($"Pattern Matching: Распознано число — Найдено {goldCoins} монет");
            }




            List<int> goldList = new List<int> { 10, 50, 120, 30, 200, 5, 80 };

            var richPockets = goldList
                .Where(g => g > 40)
                .OrderByDescending(g => g)
                .ToList();

            Console.WriteLine("LINQ выборка (золото > 40, по убыванию):");
            foreach (var gold in richPockets)
            {
                Console.WriteLine($" - Сумка с золотом: {gold}");
            }

            int totalGold = richPockets.Sum();
            Console.WriteLine($"Всего собрано золота из больших сумок: {totalGold}");


            Console.ReadKey();
        }
    }




    public class Entity
    {
        public int Health { get; set; } = 100;
    }

    public class Player : Entity
    {
        public int Mana { get; set; } = 0;

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}