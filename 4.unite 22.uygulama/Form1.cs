using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_22.uygulama
{
    public partial class Form1 : Form
    {
        ArrayList kaynakveri = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap=new Kitap();
            kitap.Kitapadi = txtKitapAdi.Text;
            kitap.KitapTur = txtKitapTuru.Text;
            kitap.KitapYazar = txtKitapYazar.Text;
            kaynakveri.Add(kitap);


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listeVeri.DataSource = null;
            listeVeri.DataSource = kaynakveri;
            listeVeri.DisplayMember ="KitapAdi";
   
        }
    }
}
