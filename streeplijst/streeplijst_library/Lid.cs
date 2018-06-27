using System;
using System.Collections.Generic;
using System.Text;

namespace streeplijst_library
{
    
    public class Lid
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Number { get; set; }
        public string Team { get; set; }
        public string Commissies { get; set; }
        public Item Items { get; set; }

        public Lid()
        {
            Team = null;
            Number = 0;
        }
        public String Display
        {
            
            get
            {
                return Firstname + "\t" + Lastname;
            }
        }
    }
}
