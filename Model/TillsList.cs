using System;
using System.Collections.Generic;
using System.Linq;

namespace Task.Model
{
    public class TillsList : List<Till>
    {
        public void Work()
        {
            foreach (var item in this) item.Work();
        }

        public int AddHuman(Human human, Random rand)
        {
            var index = 0;
            if (human is Child)
            {
                index = rand.Next(Count);
                this[index].HumansQueue.Enqueue(human);
            }
            else
            {
                if (human is Woman)
                {
                    var obj = this.OrderBy(x => x.GetAllHumans()).First();
                    index = IndexOf(obj);
                    this[index].HumansQueue.Enqueue(human);
                }
                else
                {
                    var obj = this.OrderBy(x => x.GetAllSteps()).First();
                    index = IndexOf(obj);
                    this[index].HumansQueue.Enqueue(human);
                }
            }

            return index;
        }

        public void Display(int indexLastTill)
        {
            for (var i = 0; i < Count; i++) this[i].Display(indexLastTill == i);
        }
    }
}