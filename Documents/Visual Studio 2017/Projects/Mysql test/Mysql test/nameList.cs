using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql_test
{
    class NameList
    {
        public string firstName { get; set; }
        public int ID { get; set; }
        public string lastName { get; set; }
        public Items items { get; set; }

        public String Display
        {
            get
            {
                return $"{firstName} \t {lastName}";
            }
        }
    }
}
