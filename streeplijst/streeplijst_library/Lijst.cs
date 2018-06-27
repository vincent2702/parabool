using System;
using System.Collections.Generic;
using System.Text;

namespace streeplijst_library
{
    public class Lijst
    {
        public List<Lid> Leden { get; set; }
        public List<Item> Items { get; set; }
        public List<PriceList> Price { get; set; }
        public List<Teams> Teams { get; set; }


        public Lijst()
        {
            Leden = new List<Lid>();
            Items = new List<Item>();
            Price = new List<PriceList>();
            Teams = new List<Teams>();
        }
    }
}
