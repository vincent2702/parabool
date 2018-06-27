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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstName.Text != "" && lastName.Text != "")
            {
                FormList.form1.dBConnect.addPerson(firstName.Text, lastName.Text);
                if (TeamText.Text == "" && Commisie_number.Text == "")
                {
                    FormList.form1.dBConnect.addStreeplijstData(firstName.Text, 8, 12);
                }
                else if (TeamText.Text == "" && Commisie_number.Text != "")
                {
                    FormList.form1.dBConnect.addStreeplijstData(firstName.Text, 8, Convert.ToInt16(Commisie_number.Text));
                }
                else if (TeamText.Text != "" && Commisie_number.Text == "")
                {
                    FormList.form1.dBConnect.addStreeplijstData(firstName.Text, Convert.ToInt16(TeamText.Text), 12);

                }
                else
                {
                    FormList.form1.dBConnect.addStreeplijstData(firstName.Text, Convert.ToInt16(TeamText.Text), Convert.ToInt16(Commisie_number.Text));

                }
                
                firstName.Text = "";
                lastName.Text = "";
                TeamText.Text = "";
                Commisie_number.Text = "";
            }
            else
            {
                MsgBox.Show("No firstname or lastname", "", "", "");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
