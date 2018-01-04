using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard
{
    public partial class keyboard : Form
    {
        
        public keyboard()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }


        private void KeyBoard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("q");

        }
        private void button29_Click(object sender, EventArgs e)
        {
            SendKeys.Send("v");

        }
        private void button22_Click(object sender, EventArgs e)
        {
            SendKeys.Send("a");

        }
    }
}
