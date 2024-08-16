using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubG
{
    public partial class Form1 : Form
    {
        public void OyunBasladi()
        {
            MessageBox.Show("Oyun Başladı", "Start");
        }
        public void KarakterEkle()
        {
            Karakterler user = new Karakterler();

            user.KarakterAdi = tbKarakterAdi.Text;
            user.KarakterSeviyesi = cbSeviye.SelectedText;

            lbOyundakiler.Items.Add(user.KarakterAdi);
        }
        public void SilahEkle()
        {
            Silahlar silah = new Silahlar();
            silah.SilahTuru = tbSilahTuru.Text;
            silah.MermiSay = Convert.ToInt16(tbMermiSAyisi.Text);

            lbSilahlar.Items.Add(silah.SilahTuru);
        }
        private void btnOyunGir_Click(object sender, EventArgs e)
        {

            KarakterEkle();
            SilahEkle();
            OyunBasladi();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
