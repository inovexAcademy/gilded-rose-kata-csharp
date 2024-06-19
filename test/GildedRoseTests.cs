using GildedRose;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality_ItemFooAdded_FirstItemIsItemFoo()
        {
            IList<Item> Items = new List<Item> { new Item("foo", 0, 0) };
            GildedRose.GildedRose app = new GildedRose.GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal("foo", Items[0].Name);
        }
    }
}