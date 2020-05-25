using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ekspedisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double diskon = 0.1;
            double total;
            double addbiaya=0;
            double totalbiaya=0;
            string prov = "JAWA";
            int tgl = 1;
            double biayaperkg = 0;
            double berat = 0;

            biayaperkg = Convert.ToInt32(txtbiayaperkg.Text);
            prov = provinsibox.Text;
            berat = Convert.ToDouble (txtberat.Text);
            tgl = Convert.ToInt32 (txttanggal.Text);

            total = berat * biayaperkg;
            txttotal.Text = txttotal.Text + "Harga Per Kg adalah : " + biayaperkg + "\r\n";

            if ((prov == "BALI") || (prov == "JAWA"))
            {
                addbiaya = 100;
            }
            else 
            {
                addbiaya = 500;
            }

            txttotal.Text = txttotal.Text + "Berat Paket Adalah: " + berat + "\r\n";
            txttotal.Text = txttotal.Text + "Provinsi Tujuan: " + prov + "\r\n";
            txttotal.Text = txttotal.Text + "Tanggal Pengiriman Paket Adalah: " + tgl + "\r\n";

            if (tgl <= 15) ;
            {
                totalbiaya = biayaperkg * diskon;
                txttotal.Text = txttotal.Text + "Harga Total :" + (total + addbiaya - totalbiaya) + "\r\n";
            }
            
            {
                txttotal.Text = txttotal.Text + "Harga Total :" + (total + addbiaya + totalbiaya) + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            provinsibox.Text = "";
            txttanggal.Text = "";
            txtberat.Text = "";
            txttotal.Text = "";
        }
    }
}
