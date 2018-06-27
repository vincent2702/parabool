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
    public partial class Prices : Form
    {

        public Prices()
        {
            InitializeComponent();
            FormList.form1.dBConnect.priceList();
            Bier_price.Text = Convert.ToString(FormList.form1.dBConnect.price.Bier_price);
            Wijn_price.Text = Convert.ToString(FormList.form1.dBConnect.price.Wijn_price);
            Snoep_price.Text = Convert.ToString(FormList.form1.dBConnect.price.Snoep_price);
            Fris_price.Text = Convert.ToString(FormList.form1.dBConnect.price.Fris_price);
            AA_price.Text = Convert.ToString(FormList.form1.dBConnect.price.AA_price);
            New_bier_price.Value = Convert.ToDecimal(FormList.form1.dBConnect.price.Bier_price);
            New_Wijn_price.Value = Convert.ToDecimal(FormList.form1.dBConnect.price.Wijn_price);
            New_Snoep_price.Value = Convert.ToDecimal(FormList.form1.dBConnect.price.Snoep_price);
            New_Fris_price.Value = Convert.ToDecimal(FormList.form1.dBConnect.price.Fris_price);
            New_AA_price.Value = Convert.ToDecimal(FormList.form1.dBConnect.price.AA_price);

        }

        private void Update_price_list_Click(object sender, EventArgs e)
        {


            FormList.form1.dBConnect.UpdatePriceList(Convert.ToDouble(New_bier_price.Value),
                                                     Convert.ToDouble(New_Fris_price.Value), 
                                                     Convert.ToDouble(New_Wijn_price.Value), 
                                                     Convert.ToDouble(New_Snoep_price.Value), 
                                                     Convert.ToDouble(New_AA_price.Value));
            this.Close();
        }
    }
}
