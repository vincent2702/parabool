using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql_test
{
    class Lijst
    {
        public List<NameList> people { set; get; }
        public List<Items> items { set; get; }

        public Lijst() {
            people = new List<NameList>();
            items = new List<Items>();
        }
    }
}
