using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streeplijst
{
    public class FormList
    {
        private static Form1 _Form1 = new Form1();
        public static Form1 form1  {get { return _Form1; }}
        private static Form2 _Form2 = new Form2();
        public static Form2 form2 { get { return _Form2; } }
        private static Form3 _Form3 = new Form3();
        public static Form3 form3 { get { return _Form3; } }
        private static Form4 _Form4 = new Form4();
        public static Form4 form4 { get { return _Form4; } }
        //private static KeyBoard _KeyBoard = new KeyBoard();
        //public static KeyBoard keyBoard { get { return _KeyBoard; } }


        public FormList() {
            form4.Show();
        }
    }
}
