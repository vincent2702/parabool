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
using System.Collections;
using System.IO.Ports;

namespace streeplijst
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
           // this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            List_Update();
        }
        String name;
        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {

            FormList.form2.textBox1.Clear();
            FormList.form2.textBox1.Focus();
            FormList.form2.Show();
            FormList.form4.Hide();
        }
        public void Formchange() {
            
        }
        private void change()
        {
            FormList.form4.Hide();
        }

        public void List_Update()
        {
            bierlijst.Items.Clear();
            FormList.form1.dBConnect.Top10();
            int j = 0;
            foreach (Lid lid in FormList.form1.dBConnect.lijst2.Leden)
            {
                j++;
                String[] arr = new string[4];
                ListViewItem itm;
                arr[0] = lid.Firstname.ToString();
                arr[1] = lid.Lastname.ToString();
                arr[2] = lid.Items.ItemCountTotalBier2.ToString();
                arr[3] = j.ToString(); ;
                itm = new ListViewItem(arr);
                bierlijst.Items.Add(itm);
                
            }
            
            for (int i = 0; i <= 7; i++)
            {
                int bier_total = 0;
                foreach (Lid lid in FormList.form1.dBConnect.lijst2.Leden)
                {
                  
                        if (lid.Team == $"{i}")
                        {
                            bier_total += lid.Items.ItemCountTotalBier2;
                        }
                    
                }
                FormList.form1.dBConnect.addBietToTeams(bier_total, i, "teams", "idteams");
                
                
            }

            for (int i = 0; i <= 11; i++)
            {
                int bier_total = 0;
                foreach (Lid lid in FormList.form1.dBConnect.lijst2.Leden)
                {
                  
                        if (lid.Commissies == $"{i}")
                        {
                            bier_total += lid.Items.ItemCountTotalBier2;
                        }
                    
                }
                FormList.form1.dBConnect.addBietToTeams(bier_total, i, "commissies", "idcommisies");


            }

            bier_teams.Items.Clear();
            FormList.form1.dBConnect.topTeams();
            foreach (Teams team in FormList.form1.dBConnect.teams_bier.Teams)
            {
                if (team.Team != "De parabool 0")
                {
                    String[] arr = new string[2];
                    ListViewItem itm;
                    arr[0] = team.Team;
                    arr[1] = team.Bier_count.ToString();
                    itm = new ListViewItem(arr);
                    bier_teams.Items.Add(itm);
                }
            }

            CommissieBier.Items.Clear();
            FormList.form1.dBConnect.topCommissies();
            foreach (Teams team in FormList.form1.dBConnect.teams_bier.Teams)
            {
                if (team.Commissie != "geen")
                {
                    String[] arr = new string[2];
                    ListViewItem itm;
                    arr[0] = team.Commissie;
                    arr[1] = team.Bier_count.ToString();
                    itm = new ListViewItem(arr);
                    CommissieBier.Items.Add(itm);
                }
            }
        }


    }
}
