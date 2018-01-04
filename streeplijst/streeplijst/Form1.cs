﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using streeplijst_library;

namespace streeplijst
{
    public partial class Form1 : Form
    {

        /*
        *
        * lijst is a List of items and Names 
        * The intergers are for adding and decreasing the items counts
        * fullName is a public String with a get and set so form to can change the variable.
        */
        //public Lijst lijst = new Lijst();
        public DBConnect dBConnect = new DBConnect();
        int BierCount = 0;
        int FrisCount = 0;
        int SnoepCount = 0;
        int WijnCount = 0;
        public String fullName { get; set; }
        /*
         * Form1 starts the first interface. sets up the data and calls the UpdatText method 
         * */
        public Form1()
        {
            InitializeComponent();
            
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            //SetUpData();
            dBConnect.SearchDB("");
            UpdateText();

        }
        /*
         * 
         * Updates the Name Textbox and Items TextBox.
         * Is public becaus form to need to update the text As well
         * fulname is the name past trhoug from form two.
         * 
         * */
        public void UpdateText()
        {
            name.Text = fullName;
            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text == lid.Firstname + "\t" + lid.Lastname) {
                    textBox1.Text = lid.Items.Bier + ":\t" + lid.Items.ItemCountBier + "\r\n" +
                                    lid.Items.Fris + ":\t" + lid.Items.ItemCountFris + "\r\n" +
                                    lid.Items.Snoep + ":\t" + lid.Items.ItemCountSnoep + "\r\n" +
                                    lid.Items.Wijn + ":\t" + lid.Items.ItemCountWijn + "\r\n";
                }
            }
        }

        /*
         * SetUpData is for the data setup it uses the streeplijst_library where the list are stored.
         * */
        public void SetUpData()
        {
            int count = 0;
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\vince\Documents\Visual Studio 2017\streeplijst\streeplijst\bin\Debug\ledenLijst.txt");
            foreach (String line in lines)
            {
                dBConnect.lijst.Items.Add(new Item { });
                String[] words = line.Split(';');
                dBConnect.lijst.Leden.Add(new Lid { Firstname = words[0], Lastname = words[1], Number = count, Items = dBConnect.lijst.Items[count] });
                count++;
            }


        }

        /*
         * These are the buttons to controll the input. they change the item List coresponding to the name in the Leden List.
         * */
        private void Bier_Click0(object sender, EventArgs e)
        {

            BierCount++;
            
            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                {
                    lid.Items.ItemCountBier = BierCount;
                    UpdateText();
                }
                
            }
            //itemsBinding.ResetBindings(false);

            

        }
        private void Bier_Click1(object sender, EventArgs e)
        {

            BierCount--;
            if (BierCount < 0)
            {
                BierCount = 0;
            }
            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                {
                    lid.Items.ItemCountBier = BierCount;
                    UpdateText();
                }

            }
            



        }
        private void Fris_Click0(object sender, EventArgs e)
        {
            FrisCount++;
            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                {
                    lid.Items.ItemCountFris = FrisCount;
                    UpdateText();
                }

            }
            
        }
        private void Fris_Click1(object sender, EventArgs e)
        {
            FrisCount--;
            if (FrisCount < 0)
            {
                FrisCount = 0;
            }
            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                {
                    lid.Items.ItemCountFris = FrisCount;
                    UpdateText();
                }

            }
            
        }
        private void Snoep_Click0(object sender, EventArgs e)
        {
            SnoepCount++;
            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                {
                    lid.Items.ItemCountSnoep = SnoepCount;
                    UpdateText();
                }

            }
            
        }
        private void Snoep_Click1(object sender, EventArgs e)
        {
            SnoepCount--;
            if (SnoepCount < 0)
            {
                SnoepCount = 0;
            }
            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                {
                    lid.Items.ItemCountSnoep = SnoepCount;
                    UpdateText();
                }

            }
        }
        private void Wijn_Click0(object sender, EventArgs e)
            {
                WijnCount++;
                foreach (Lid lid in dBConnect.lijst.Leden)
                {
                    if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                    {
                        lid.Items.ItemCountWijn = WijnCount;
                        UpdateText();
                    }

                }
            }   
        private void Wijn_Click1(object sender, EventArgs e)
            {
                WijnCount--;
                if (WijnCount < 0)
                {
                    WijnCount = 0;
                }
                foreach (Lid lid in dBConnect.lijst.Leden)
                {
                    if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                    {
                        lid.Items.ItemCountWijn = WijnCount;
                        UpdateText();
                    }

                }

        }



        private void Klaar_Click(object sender, EventArgs e)
        {

            BierCount = 0;
            FrisCount = 0;
            SnoepCount = 0;
            WijnCount = 0;
            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text == lid.Firstname + "\t" + lid.Lastname)
                {
                    lid.Items.ItemCountTotalBier += lid.Items.ItemCountBier;
                    lid.Items.ItemCountTotalFris += lid.Items.ItemCountFris;
                    lid.Items.ItemCountTotalSnoep += lid.Items.ItemCountSnoep;
                    lid.Items.ItemCountTotalWijn += lid.Items.ItemCountWijn;
                    dBConnect.Update(lid.Items.ItemCountTotalBier, lid.Items.ItemCountTotalFris, lid.Items.ItemCountTotalWijn, lid.Items.ItemCountTotalSnoep, lid.Items.Id);
                    lid.Items.ItemCountBier = 0;
                    lid.Items.ItemCountFris = 0;
                    lid.Items.ItemCountSnoep = 0;
                    lid.Items.ItemCountWijn = 0;
                    UpdateText();
                }
            }
            dBConnect.SearchDB("");
            FormList.form2.Update_List();
            FormList.form4.List_Update();
            FormList.form4.Show();
            //FormList.form2.Show();
            FormList.form1.Hide();

        }
        
    }
}
