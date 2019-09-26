using System;
using Task.Model;

namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tills = new TillsList();
            tills.Add(new Till("1", 1));
            tills.Add(new Till("2", 2));
            tills.Add(new Till("3", 3));
            var humans = new HumansQueue();
            //очередь в магазин
            humans.Enqueue(new Child(10));
            humans.Enqueue(new Woman(15));
            humans.Enqueue(new Man(5));

            var shop = new Shop(tills, humans);
            shop.Work(25);
            Console.ReadKey();
        }
    }
}