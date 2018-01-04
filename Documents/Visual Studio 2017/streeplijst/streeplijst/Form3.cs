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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter writeFile = new StreamWriter(@"C:\Users\vince\Documents\Visual Studio 2017\streeplijst\streeplijst\bin\Debug\out.txt", false);
            writeFile.WriteLine(" ;" + " ;" + "Bier;" + "Fris;" + "Snoep;" +"Wijn");
            foreach (Lid lijst in FormList.form1.dBConnect.lijst.Leden)
            {
                writeFile.WriteLine(lijst.Firstname + ";" + lijst.Lastname + ";" + 
                                    lijst.Items.ItemCountTotalBier + ";" + 
                                    lijst.Items.ItemCountTotalFris + ";" + 
                                    lijst.Items.ItemCountTotalSnoep + ";" +
                                    lijst.Items.ItemCountTotalWijn);                
            }
            writeFile.Flush();
            writeFile.Close();
            writeFile = null;
        }
    }
}
