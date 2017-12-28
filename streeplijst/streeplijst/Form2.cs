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
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Update_List();
        }

        public void Update_List()
        {
            ledenBinding.DataSource = FormList.form1.dBConnect.lijst.Leden;
            NameList.DataSource = null;
            NameList.DataSource = ledenBinding;

            NameList.DisplayMember = "Display";
            NameList.ValueMember = "Display";
        }

        private void NameList_MouseClick(object sender, MouseEventArgs e)
        {
            
            if ((String)NameList.SelectedValue == "penning\tmeester")
            {
                FormList.form3.Show();
                FormList.form2.Hide();
                FormList.form1.Hide();
                
            }
            else
            {
                FormList.form2.Hide();
                FormList.form1.Show();
                FormList.form1.fullName = (String)NameList.SelectedValue;
                FormList.form1.UpdateText();
            }
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            var x = textBox1.Text;
            FormList.form1.dBConnect.SearchDB(x);
            Update_List();
            //int index = NameList.FindString(this.textBox1.Text);
            //if (0 <= index)
            //{
            //    NameList.SelectedIndex = index;

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Users/vince/Documents/Visual Studio 2017/Projects/keyboard/keyboard/bin/Debug/keyboard.exe");
            //Keyboard keyboard = new Keyboard();
            //keyboard.Show();
        }
    }
}
