using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class UpdateQualityValue
    {
        List<Item> items = new List<Item>
            {
                new Item { Name="+5 Dexterity Vest", SellIn=10,Quality=20},
                new Item { Name="Aged Brie", SellIn=2,Quality=0},
                new Item { Name="Bixir of the Mongoose", SellIn=5,Quality=7},
                new Item { Name="Sulflrus", SellIn=0,Quality=80},
                new Item { Name="Backstage Passes", SellIn=15,Quality=20},
                new Item { Name="Conjured", SellIn=3,Quality=6},
            };
        public void UpdateQuality()
        {
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].SellIn > 0)
                {
                    items[i].SellIn = items[i].SellIn - 1;
                }
            }
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].Name != "Aged Brie" && items[i].Name != "Backstage Passes")
                {
                    if (items[i].Name == "Conjured" && items[i].Quality > 1 && items[i].Quality >= 2)
                    {
                        items[i].Quality = items[i].Quality - 2;
                    }

                    else if (items[i].Name != "Sulflrus" && items[i].Quality >= 1)
                    {
                        items[i].Quality = items[i].Quality - 1;
                    }
                }
                else
                {
                    if (items[i].Name == "Backstage Passes")
                    {
                        if (items[i].SellIn == 0)
                        {
                            items[i].Quality = 0;
                        }
                        else if (items[i].SellIn <= 5 && items[i].Quality < 48)
                        {
                            items[i].Quality = items[i].Quality + 3;
                        }
                        else if (items[i].SellIn <= 10 && items[i].Quality < 49)
                        {
                            items[i].Quality = items[i].Quality + 2;
                        }
                        else if (items[i].SellIn > 10 && items[i].Quality < 50)
                        {
                            items[i].Quality = items[i].Quality + 1;
                        }
                    }
                    else if (items[i].Name == "Aged Brie" && items[i].Quality < 50)
                    {
                        items[i].Quality = items[i].Quality + 1;
                    }
                }
            }
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Name + "  " + items[i].SellIn + " " + items[i].Quality);
            }
        }
    }
}       
    

