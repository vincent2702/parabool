using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using streeplijst_library;


namespace streeplijst
{
    public partial class Form2 : Form
    {
       
        BindingSource itemsBinding = new BindingSource();
        BindingSource ledenBinding = new BindingSource();
        
        public Form2()
        {
            InitializeComponent();
           // this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ActiveControl = textBox1;
            Update_List();
            
        }

        public void Update_List()
        {
            timer1.Start();
            textBox1.Focus();
            this.ActiveControl = textBox1;
            ledenBinding.DataSource = FormList.form1.dBConnect.lijst.Leden;
            NameList.DataSource = null;
            NameList.DataSource = ledenBinding;

            NameList.DisplayMember = "Display";
            NameList.ValueMember = "Display";
        }

        private void NameList_MouseClick(object sender, MouseEventArgs e)
        {


            if ((String)NameList.SelectedValue != "penning\tmeester")
            {
                FormList.form2.Hide();
                FormList.form1.Show();
                FormList.form1.fullName = (String)NameList.SelectedValue;
                FormList.form1.UpdateText();
                FormList.form1.timer1.Start(); 
                textBox1.Clear();
                timer1.Stop();
            }
            else
            {
                timer1.Stop();
                if (LogIn.Show("") == DialogResult.Yes)
                {
                    FormList.form3.Show();
                    FormList.form2.Hide();
                    FormList.form1.Hide();
                    FormList.form1.timer1.Stop(); 
                    

                }
                else
                {
                    textBox1.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var x = textBox1.Text;
            FormList.form1.dBConnect.SearchDB(x);
            Update_List();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormList.form4.Show();
            FormList.form2.textBox1.Focus();
            FormList.form2.Hide();
            timer1.Stop();
        }
        
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FormList.form4.Show();
            FormList.form2.Hide();
            timer1.Stop();

        }
    }
}
