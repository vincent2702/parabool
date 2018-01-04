using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using streeplijst_library;

namespace streeplijst
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            List_Update();
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            FormList.form2.Show();
            FormList.form4.Hide();
        }

        public void List_Update()
        {
            bierlijst.Items.Clear();
            FormList.form1.dBConnect.Top10();
            foreach (Lid lid in FormList.form1.dBConnect.lijst2.Leden)
            {
                String[] arr = new string[3];
                ListViewItem itm;
                arr[0] = lid.Firstname.ToString();
                arr[1] = lid.Lastname.ToString();
                arr[2] = lid.Items.ItemCountTotalBier.ToString();
                itm = new ListViewItem(arr);
                bierlijst.Items.Add(itm);
            }
        }
    }
}
