using System;

namespace Task.Model
{
    internal class Shop
    {
        public Shop(TillsList tillsList, HumansQueue humansQueue)
        {
            TillsList = tillsList;
            HumansQueue = humansQueue;
        }

        public TillsList TillsList { get; }
        public HumansQueue HumansQueue { get; }

        public void Work(int steps)
        {
            if (TillsList.Count == 0 || steps == 0) Console.WriteLine("Магазин не работает");
            var totalSeconds = DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds;
            var rand = new Random((int) totalSeconds);

            var indexOfLastTill = 0;
            foreach (var item in HumansQueue) indexOfLastTill = TillsList.AddHuman(item, rand);


            for (var i = 0; i < steps; i++)
            {
                TillsList.Work();

                var human = CreateNewHuman(rand);
                indexOfLastTill = TillsList.AddHuman(human, rand);
            }

            TillsList.Display(indexOfLastTill);
        }

        private static Human CreateNewHuman(Random rand)
        {
            var val = rand.Next(10);
            if (val == 0) return new Child(rand.Next(10) + 1);

            if (val < 5)
                return new Woman(rand.Next(20) + 1);
            return new Man(rand.Next(5) + 1);
        }
    }
}