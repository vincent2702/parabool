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
    public partial class LogIn : Form
    {
        public String Password = "parabool987";
        public LogIn()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        static LogIn _LogIn; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Caption)
        {
            _LogIn = new LogIn();
            _LogIn.label1.Text = "Enter Pasword";
            _LogIn.EnterPasword.Text = "Enter";
            _LogIn.Text = Caption;
            _LogIn.ShowDialog();
            return result;
        }

        private void EnterPasword_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;

            if (_LogIn.Pasword.Text == "parabool987")
            {
                _LogIn.Close();
            }
            else
            {
                result = DialogResult.No;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; _LogIn.Close();
        }

        public void Change_Password(String password)
        {
            Password = password;
        }
    }
}
