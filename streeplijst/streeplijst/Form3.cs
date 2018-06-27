using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using streeplijst_library;

namespace streeplijst
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            //this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MsgBox.Show("weet je het zeker", "", "JA", "NEE") == DialogResult.Yes)
            {
                FormList.form1.dBConnect.priceList();
                String date = Convert.ToString(DateTime.Today.Date);
                date = date.Replace("/", "-").Substring(0, date.IndexOf(" "));
                
                TextWriter writeFile = new StreamWriter($@"C:\Users\vince\Desktop\streeplijst data\{date}.txt", false);
                writeFile.WriteLine(date + ";" + " ;" + "Bier;" + "Opbrengst;" + "Fris;" + "Opbrengst;" + "Snoep;" +
                                    "Opbrengst;" + "AA;" + "Opbrengst;" + "Wijn;" + "Opbrengst;" + "totaal;" + "Opbrengst");

                FormList.form1.dBConnect.lijst.Leden.Sort((y, x) => y.Firstname.CompareTo(x.Firstname));
                FormList.form1.dBConnect.SearchDB("");
                foreach (Lid lijst in FormList.form1.dBConnect.lijst.Leden)
                {
                    var Bier_total_price = lijst.Items.ItemCountTotalBier * FormList.form1.dBConnect.price.Bier_price;
                    var Wijn_total_price = lijst.Items.ItemCountTotalWijn * FormList.form1.dBConnect.price.Wijn_price;
                    var Fris_total_price = lijst.Items.ItemCountTotalFris * FormList.form1.dBConnect.price.Fris_price;
                    var Snoep_total_price = lijst.Items.ItemCountTotalSnoep * FormList.form1.dBConnect.price.Snoep_price;
                    var AA_total_price = lijst.Items.ItemCountTotalAA * FormList.form1.dBConnect.price.AA_price;
                    var total_price = Bier_total_price + Wijn_total_price + Fris_total_price + Snoep_total_price + AA_total_price;
                    var Totaal = lijst.Items.ItemCountTotalBier + lijst.Items.ItemCountTotalSnoep + lijst.Items.ItemCountTotalAA + lijst.Items.ItemCountTotalWijn + lijst.Items.ItemCountTotalFris;


                    writeFile.WriteLine(lijst.Firstname + ";" + lijst.Lastname + ";" +
                                        lijst.Items.ItemCountTotalBier + ";" + Bier_total_price + ";" +
                                        lijst.Items.ItemCountTotalFris + ";" + Fris_total_price + ";" +
                                        lijst.Items.ItemCountTotalSnoep + ";" + Snoep_total_price + ";" +
                                        lijst.Items.ItemCountTotalAA + ";" + AA_total_price + ";" +
                                        lijst.Items.ItemCountTotalWijn + ";" + Wijn_total_price + ";" +
                                        Totaal + ";" + total_price);

                    FormList.form1.dBConnect.Update("streeplijst", 0, 0, 0, 0, 0, lijst.Items.Id);
                }
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
        }

        private void add_person_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.Show();
        }

        private void remove_person_Click(object sender, EventArgs e)
        {
            DeletePerson deletePerson = new DeletePerson();
            deletePerson.Show();
        }

        private void change_price_Click(object sender, EventArgs e)
        {
            Prices prices = new Prices();
           
            prices.Show();
        }

        private void change_person_data_Click(object sender, EventArgs e)
        {
            PersonData person = new PersonData();
            person.Show();
        }

        private void terug_Click(object sender, EventArgs e)
        {
            FormList.form2.Show();
            FormList.form3.Hide();
            FormList.form2.textBox1.Text = "";
        }

        private void streepen_Click(object sender, EventArgs e)
        {
            FormList.form3.Hide();
            FormList.form1.Show();
            FormList.form1.fullName = "penning\tmeester";
            FormList.form1.UpdateText();
            FormList.form1.timer1.Start();
        }

        private void Stock_Update_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }
    }
}
