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
    public partial class PersonData : Form
    {
        public PersonData()
        {
            InitializeComponent();
        }



        String[] data;
        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                data = FormList.form1.dBConnect.PersonData(SerachBox.Text);
                SerachBox.Text = "";
                FullName.Text = data[0] + " " + data[1];
                Team.Text = data[7];
                Commissie.Text = data[8];
                ID.Text = data[9];
                Bier.Text = data[2];
                Fris.Text = data[3];
                Wijn.Text = data[4];
                Snoep.Text = data[5];
                AA.Text = data[6];
            }
            catch (Exception)
            {

                Console.WriteLine("no full name");                
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            FormList.form1.dBConnect.Update("streeplijst", Convert.ToInt16(Bier.Text), Convert.ToInt16(Fris.Text), Convert.ToInt16(Wijn.Text), Convert.ToInt16(Snoep.Text), Convert.ToInt16(AA.Text), Convert.ToInt16(ID.Text));
            int Bier_totaal = Convert.ToInt16(Bier.Text) + Convert.ToInt16(data[10]);
            int Fris_totaal = Convert.ToInt16(Fris.Text) + Convert.ToInt16(data[11]);
            int Snoep_totaal = Convert.ToInt16(Snoep.Text) + Convert.ToInt16(data[12]);
            int Wijn_totaal = Convert.ToInt16(Wijn.Text) + Convert.ToInt16(data[13]);
            int AA_totaal = Convert.ToInt16(AA.Text) + Convert.ToInt16(data[14]);
            FormList.form1.dBConnect.Update("streeplijst_total", Bier_totaal,Fris_totaal, Snoep_totaal, Wijn_totaal, AA_totaal, Convert.ToInt16(ID.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormList.form1.dBConnect.Update("teams_has_nameslist", Convert.ToInt16(ID.Text), Convert.ToInt16(Team.Text), Convert.ToInt16(Commissie.Text));
        }
    }
}
