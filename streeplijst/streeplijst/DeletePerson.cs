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
    public partial class DeletePerson : Form
    {
        public DeletePerson()
        {
            InitializeComponent();
        }


private void button1_Click(object sender, EventArgs e)
        {
            if (firstName.Text != "" && lastName.Text != "")
            {
                FormList.form1.dBConnect.DeletPerson(firstName.Text, lastName.Text);
                firstName.Text = "";
                lastName.Text = "";
            }
            else
            {
                MsgBox.Show("No firstname or lastname", "", "", "");
            }
        }
    
    }
}
