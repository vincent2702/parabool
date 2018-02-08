using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace streeplijst
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        static MsgBox _MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string text, string Caption, string yes, string no)
        {
            _MsgBox = new MsgBox();
            _MsgBox.label1.Text = text;
            _MsgBox.button1.Text = yes;
            _MsgBox.button2.Text = no;
            _MsgBox.Text = Caption;
            _MsgBox.ShowDialog();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; _MsgBox.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; _MsgBox.Close();
        }
    }
}
