using System;

namespace Task.Model
{
    public class Till
    {
        public Till(string name, int speed)
        {
            Speed = speed;
            Name = name;
            HumansQueue = new HumansQueue();
        }

        public string Name { get; }
        public int Speed { get; }
        public HumansQueue HumansQueue { set; get; }

        public int GetAllSteps()
        {
            var val = 0;
            foreach (var item in HumansQueue)
            {
                val += item.CountProduct / Speed;
                if (item.CountProduct % Speed > 0) val += 1;
            }

            return val;
        }

        public int GetAllHumans()
        {
            return HumansQueue.Count;
        }

        public override string ToString()
        {
             return $"[{Speed}]";
        }

        public void Work()
        {
            if (HumansQueue.Count > 0)
            {
                HumansQueue.Peek().CountProduct = HumansQueue.Peek().CountProduct - Speed;
                if (HumansQueue.Peek().CountProduct <= 0)
                {
                    HumansQueue.Dequeue();
                }
            }
        }

        public void Display(bool b)
        {
            Console.Write(this + " ");
            foreach (var item in HumansQueue)
            {
                Console.Write(item + " ");
            }

            if (b)
            {
                Console.Write("*");
            }
            Console.WriteLine();


        }
    }
}