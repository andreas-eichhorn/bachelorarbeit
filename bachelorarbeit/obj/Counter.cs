using System;

namespace processing
{
    public class Counter
    {
        private int counter;
        private int chance;
        private readonly int maxChance;

        public Counter(int initialCounter, int maxChance = 3)
        {
            this.counter = initialCounter;
            this.chance = maxChance;
            this.maxChance = maxChance;
        }

        public void decreaseCounter()
        {
            if(counter > 0)
                counter--;
        }

        public void decreaseChance()
        {
            if(chance > 0)
                chance--;
        }

        public void resetChance()
        {
            chance = maxChance;
        }

        public int GetChance() => chance;
    }
}