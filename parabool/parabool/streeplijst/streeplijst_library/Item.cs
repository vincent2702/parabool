using System;
using System.Collections.Generic;
using System.Text;

namespace streeplijst_library
{
    public class Item
    {
        //public String Name { get; set; }
        public String Bier { get; set; }
        public String Wijn { get; set; }
        public String Fris { get; set; }
        public String Snoep { get; set; }

        public int ItemCountBier { get; set; }
        public int ItemCountFris { get; set; }
        public int ItemCountSnoep { get; set; }
        public int ItemCountWijn { get; set; }

        public int ItemCountTotalBier { get; set; }
        public int ItemCountTotalFris { get; set; }
        public int ItemCountTotalSnoep { get; set; }
        public int ItemCountTotalWijn { get; set; }

        public int Id { get; set; }

        public int ItemCount { get; set; }
        public int ItemCountTotal { get; set; }

        public string Display
        {
            get
            {
                String a = "\n";
                return Bier + ":    " + ItemCount + ":    " + ItemCountTotal
                    + a + Bier + ":    " + ItemCount + ":    " + ItemCountTotal;
            }
        }

        public Item()
        {
            Id = 0;
            Bier = "Bier";
            Wijn = "Wijn";
            Snoep = "Snoep";
            Fris = "Fris";
            ItemCount = 0;
            ItemCountTotal = 0;
            ItemCountBier = 0;
            ItemCountFris = 0;
            ItemCountSnoep = 0;
            ItemCountWijn = 0;
            ItemCountTotalBier = 0;
            ItemCountTotalFris = 0;
            ItemCountTotalSnoep = 0;
            ItemCountTotalWijn = 0;
        }
    }
}
