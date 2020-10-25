using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
            int legs;
            legs = (chickens * 2) + (cows * 4) + (pigs * 4);
            return legs;
        }
    }
}