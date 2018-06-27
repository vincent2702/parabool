using System;
using System.Collections.Generic;
using System.Text;

namespace streeplijst_library
{
    public class PriceList
    {
        public Double Bier_price { get; set; }
        public Double Fris_price { get; set; }
        public Double Wijn_price { get; set; }
        public Double Snoep_price { get; set; }
        public Double AA_price { get; set; }


        public PriceList()
        {
            Bier_price = 0;
            Fris_price = 0;
            Wijn_price = 0;
            Snoep_price = 0;
            AA_price = 0;
        }
    }
}
