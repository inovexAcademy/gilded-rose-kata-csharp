namespace GildedRose
{
    public class Item
    {
        public Item(String name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return $"{Name}, {SellIn}, {Quality}";
        }
    }
}