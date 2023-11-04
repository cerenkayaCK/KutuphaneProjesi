using KutuphaneProjesi.CLASS;
using System.Windows.Forms;

namespace KutuphaneProjesi
{

    public partial class Form1 : Form
    {
        static public List<Kitap> ÝncelenecekKitaplar = new List<Kitap>();

        Kutuphane kutuphane = new Kutuphane();

        bool UyeKayitliMi = false;
        Uye Uye;
        public Form1()
        {
            InitializeComponent();
            kutuphane.KitaplariListele(cmbKitap);
            grpSecilen.Visible = false;
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            Kitap secilenKitap = (Kitap)cmbKitap.SelectedItem;
            cmbKitap.SelectedIndex = -1;
            kutuphane.TalepEdilen = new List<Kitap> { secilenKitap };

            if (secilenKitap != null)
            {
                Label label = new Label() { Tag = secilenKitap, Text = secilenKitap.Ýsim, Width = 200 };
                label.Click += renkdegistir;
                flowLayoutPanel1.Controls.Add(label);
                Kutuphane.MevcutKitaplar.Remove(secilenKitap);
                kutuphane.KitaplariListele(cmbKitap);
            }
        }

        private void renkdegistir(object? sender, EventArgs e)
        {
            if (sender is Label label) //obje label ise
            {
                if (label.BackColor == SystemColors.GradientInactiveCaption)
                    label.BackColor = System.Drawing.Color.Red;

                else if (label.BackColor == System.Drawing.Color.Red)
                    label.BackColor = SystemColors.GradientInactiveCaption;
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {

            lstSecilen.Items.Clear();
            if (!UyeKayitliMi)
            {
                MessageBox.Show("Lütfen Giriþ Yapýnýz.");
                grpUyeGiris.Visible = true;
            }
            else
            {
                foreach (Label item in flowLayoutPanel1.Controls)
                {

                    if (Uye.OduncAlinanKitap.Count < 4)
                        Uye.OduncAlinanKitap.Add((Kitap)item.Tag);
                    else MessageBox.Show("Dörtten fazla kitp alamazsýn.");

                }

                foreach (Kitap item in Uye.OduncAlinanKitap)
                {

                    lstSecilen.Items.Add(item);
                }
            }
            flowLayoutPanel1.Controls.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string girilenTckn = txtTCKN.Text;
            foreach (Uye item in Kutuphane.Uyeler)
            {
                if (item.TCKN == girilenTckn)
                {
                    txtTCKN.Text = "";
                    UyeKayitliMi = true;
                    grpUyeGiris.Visible = false;
                    grpSecilen.Visible = true;
                    Uye = item;
                    if (Uye.OduncAlinanKitap.Count > 0)
                        foreach (var ktp in Uye.OduncAlinanKitap)
                        {
                            lstSecilen.Items.Add(ktp);
                        }
                    return;
                }
            }

            if (!UyeKayitliMi)
            {
                Uye = new Uye(girilenTckn);
                Kutuphane.Uyeler.Add(Uye);
                grpUyeGiris.Visible = false;
                grpSecilen.Visible = true;
                UyeKayitliMi = true;
            }

            MessageBox.Show(UyeKayitliMi ? "GÝRÝÞ YAPILDI." : "ÜYELÝÐÝNÝZ OLUÞTURULDU. ");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            List<Label> yedek = new List<Label>();

            foreach (Label item in flowLayoutPanel1.Controls)
            {
                if (item.BackColor == System.Drawing.Color.Red)
                {
                    yedek.Add(item);
                    Kutuphane.MevcutKitaplar.Add((Kitap)item.Tag);
                }

            }
            foreach (Label item in yedek)
            {

                flowLayoutPanel1.Controls.Remove(item);

            }
            kutuphane.KitaplariListele(cmbKitap);
        }

        private void btnÝade_Click(object sender, EventArgs e)
        {
            if (lstSecilen.SelectedIndex != -1)
            {
                Kitap? secilen = lstSecilen.SelectedItem as Kitap;
                lstSecilen.Items.Remove(secilen);
                Kutuphane.MevcutKitaplar.Add(secilen);
                kutuphane.KitaplariListele(cmbKitap);
            }
            else MessageBox.Show("Lütfen iade edilecek kitabý seçiniz.");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            grpSecilen.Visible = false;
            grpUyeGiris.Visible = true;
            Uye = null;
            lstSecilen.Items.Clear();
            UyeKayitliMi = false;
            txtTCKN.Text = null;
        }

        public void FormGoster(Form secilenForm)
        {
            
            secilenForm.Show();

        }

        private void btnÝncele_Click(object sender, EventArgs e)
        {

            foreach (Label item in flowLayoutPanel1.Controls)
            {
                if (item.BackColor == System.Drawing.Color.Red)
                {
                    ÝncelenecekKitaplar.Add((Kitap)item.Tag);
                }
            }
        
            FormGoster(new incele());

        }


    }
}