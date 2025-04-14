using System;

namespace processing
{
    public class Counter
    {
        private static int counter = -1;
        private static int chance{get; set;}
        private readonly int maxChance;

        public Counter(int maxChance = 3)
        {
            Counter.chance = maxChance;
            this.maxChance = maxChance;
        }

        public void decreaseCounter()
        {
            if(Counter.counter > 0)
                Counter.counter--;
        }

        public void decreaseChance()
        {
            if(Counter.chance > 0)
                Counter.chance--;
        }

        public void resetChance()
        {
            chance = maxChance;
        }

        public void setCounter(int counter)
        {
            if(getCounter() == -1)
                Counter.counter = counter;
        }

        public int getCounter()
        {
            return counter;
        }

        public int getChance()
        {
            return chance;
        }

    }
}