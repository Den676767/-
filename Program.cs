using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IMovable
    {
        void Move();
        void show();
    }
    class Car : IMovable
    {
        public void Move()
        {

        }
        public void show()
        {

        }

    }
    public class Item
    {
        public string Name { get; set; }
        public int Cost { get; private set; }

        // Конструктор
        public Item(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
    public class Entity
    {
        public int Health { get; set; } = 100;


        public void TakeDamage(int damage) => Health -= damage;
        public void TakeDamage(int damage, bool isCritical)
        {
            Health -= isCritical ? damage * 2 : damage;
        }
    }


    public class Player : Entity
    {
        public int Mana { get; set; } = 50;
    }
    public class Unit
    {

        public virtual void Move() => Console.WriteLine("Юнит идет");
    }

    public class Hero : Unit
    {

        public override void Move() => Console.WriteLine("Герой бежит");
    }

    public struct Point2D
    {
        public int X { get; }
        public int Y { get; }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public interface IDamageable
    {
        void ApplyDamage(int amount);
    }

    public class Chest : IDamageable
    {
        public void ApplyDamage(int amount) => Console.WriteLine($"Сундук получил {amount} урона");
    }
                
          /*     int[] numbers = new int[3] { 10, 20, 30 };
            numbers[0] = 15;

            
            List<string> inventory = new List<string> { "Меч", "Щит" };
    inventory.Add("Зелье");  
            inventory.Remove("Щит");   
      */
        }
}
