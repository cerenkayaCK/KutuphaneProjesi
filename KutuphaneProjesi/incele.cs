using KutuphaneProjesi.CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class incele : Form
    {
        public incele()
        {
            InitializeComponent();
        }

        private void incele_Load(object sender, EventArgs e)
        {

           

            foreach (Kitap item in Form1.İncelenecekKitaplar)
            {
                Label labelBilgi = new Label() { Text = item.İsim + Environment.NewLine + "Kitabın Yazarı: " + item.Yazar + Environment.NewLine + "Kitabın Çeşidi: " + item.KitapCesidi + Environment.NewLine + "Sayfa Sayısı: " + item.SayfaSayisi, BorderStyle = BorderStyle.FixedSingle, Width=flowLayoutPanel2.Width-20, Height=flowLayoutPanel2.Height/Form1.İncelenecekKitaplar.Count};

                flowLayoutPanel2.Controls.Add(labelBilgi);

            }
            

                Form1.İncelenecekKitaplar.Clear();
        }
    }
}
