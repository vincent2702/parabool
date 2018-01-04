using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql_test
{
    public partial class Form1 : Form
    {
        DBConnect dBConnect = new DBConnect();

        public Form1()
        {

            dBConnect.SelectStart();
            InitializeComponent();
            UpdateBinding();
            foreach (NameList nameList in dBConnect.lijst.people)
            {
                String[] arr = new string[3];
                ListViewItem itm;
                arr[0] = nameList.firstName.ToString();
                arr[1] = nameList.lastName.ToString();
                arr[2] = nameList.items.Bier.ToString();
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            
        }

        public void UpdateBinding()
        {
            nameList.DataSource = null;
            nameList.DataSource = dBConnect.lijst.people;
            nameList.DisplayMember = "Display";
            this.Update();
        }
    }
}
