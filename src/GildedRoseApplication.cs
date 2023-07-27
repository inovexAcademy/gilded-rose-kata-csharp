namespace GildedRose
{
    public class GildedRoseApplication
    {
        public void Run()
        {
            IList<Item> items = new List<Item>();
            items.Add(new Item("+5 Dexterity Vest", 10, 20));
            items.Add(new Item("Aged Brie", 2, 0));
            items.Add(new Item("Elixir of the Mongoose", 5, 7));
            items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
            items.Add(new Item("Sulfuras, Hand of Ragnaros", -1, 80));
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49));
            items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 5, 49));
            // this Conjured item doesn't yet work properly
            items.Add(new Item("Conjured Mana Cake", 3, 6));
            GildedRose app = new GildedRose(items);

            Console.WriteLine("OMGHAI!");

            for (int day = 0; day <= 30; day++)
            {
                Console.WriteLine("-------- day " + day + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in items)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();

                app.UpdateQuality();
            }
        }
    }
}