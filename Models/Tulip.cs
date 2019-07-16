using System;

namespace FlowerShop
{
    public class Tulip : Flower, IDescribable, IStemLength, IColor
    {
        public string Color { get; set; }

        public bool HasThorns { get; set; }

        public double StemLength { get; set; }

        public int PetalCount { get; set; }


        public string Describe()
        {
            return $"A beautiful {Color} Tulip";
        }

    }
}