using System.Collections.Generic;

namespace FlowerShop
{
    public class FlowerShop
    {
        public List<Rose> Roses { get; set; }
        public List<Lilly> Lillyes { get; set; }
        public List<Sunflower> Sunflowers { get; set; }
        public List<Tulip> Tulips { get; set; }

        public List<IStemLength> MothersDayArrangement { get; set; } = new List<IStemLength>()
        {
            new Rose() { PetalCount = 27, Price = 3.00 },
            new Sunflower() { PetalCount = 50, Price = 5.00 }
        };
        public List<IColor> BirthDayArrangement { get; set; } = new List<IColor>()
        {
            new Rose () { Color = "Red", Price = 3.00 },
            new Tulip () { Color = "White", Price = 4.00 }
        };
    }
}