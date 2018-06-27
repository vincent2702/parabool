using System;
using System.Collections.Generic;
using System.Text;

namespace streeplijst_library
{
    public class Teams
    {
        public int Bier_count { get; set; }
        public String Team { get; set; }
        public String Commissie { get; set; }
        public Teams()
        {
            Team = null;
            Commissie = null;
            Bier_count = 0;

        }
    }

    
}
