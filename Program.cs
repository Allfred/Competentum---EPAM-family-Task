using System;
using Task.Model;

namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var totalSeconds = DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds;
            var rand = new Random((int)totalSeconds);

            var tills = new TillsList();
            var humans = new HumansQueue();

            tills.Add(new Till("1", rand.Next(1) + 1));
            tills.Add(new Till("2", rand.Next(2) + 1));
            tills.Add(new Till("3", rand.Next(3) + 1));
            
            //очередь в магазин
            humans.Enqueue(new Child(rand.Next(10)+1));
            humans.Enqueue(new Woman(rand.Next(15) + 1));
            humans.Enqueue(new Man(rand.Next(5) + 1));

            var shop = new Shop(tills, humans);

            shop.Work(10,rand);

            Console.ReadKey();
        }
    }
}