using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi.CLASS
{
    public class Kutuphane
    {
        public Kutuphane()
        {
            foreach (var item in TumKitaplar)
            {
                MevcutKitaplar.Add(item);
            }
        }
        public int KitapSayisi;

        public static List<Kitap> MevcutKitaplar = new List<Kitap>();

        public static List<Uye> Uyeler = new List<Uye>()
        {
            new Uye("56335323932"),
            new Uye("28973095014")
        };

        private List<Kitap> OduncVerilen { get; set; } = new List<Kitap>();

        public int OduncVerilenCount()
        {
            return OduncVerilen.Count;
        }

        public List<Kitap> TalepEdilen
        {
            get
            {
                return OduncVerilen;
            }
            set
            {
                foreach (var item in value)
                {
                    if (MevcutKitaplar.Contains(item))
                        OduncVerilen.Add(item);
                    else
                    {
                        MessageBox.Show("Aradığınız kitap bulunmamaktadır.");
                    }

                }

            }
        }
        public List<Kitap> TumKitaplar = new List<Kitap>
        {
            new Kitap("Nutuk",ENUM.Tur.Roman){ SayfaSayisi = 700, Yazar="Gazi Mustafa Kemal Atatürk", },
            new Kitap("1984",ENUM.Tur.Roman){ SayfaSayisi = 346, Yazar = "George Orwell"},
            new Kitap("Hayvan Çiftliği",ENUM.Tur.Roman){ SayfaSayisi= 315, Yazar="George Orwell"},
            new Kitap("Divan-ı Hikmet",ENUM.Tur.Siir){ SayfaSayisi=200, Yazar="Yahya Kemal Beyatlı'"},
            new Kitap("Araba Sevdası", ENUM.Tur.Roman){SayfaSayisi = 250, Yazar="Yaşar Nuri Guntekin"},
            new Kitap("Sessiz Harfler",ENUM.Tur.Siir){ SayfaSayisi=350,Yazar="Atilla İlhan"},
            new Kitap("Suç ve Ceza", ENUM.Tur.Roman){ SayfaSayisi =550, Yazar="Dostoyevski "},
            new Kitap("Sefiller",ENUM.Tur.Roman){SayfaSayisi=1300, Yazar="Victor Hugo"},
            new Kitap("Angela'nın Külleri", ENUM.Tur.Roman){ SayfaSayisi=450, Yazar="Frank McCourt"},
            new Kitap("Uçurtma Avcısı", ENUM.Tur.Roman){ SayfaSayisi=350, Yazar="Khaled Hosseini"},
            new Kitap("Piraye", ENUM.Tur.Roman){ SayfaSayisi=550, Yazar="Nazım Hikmet"},
            new Kitap("Red Kit", ENUM.Tur.CizgiRoman){SayfaSayisi=50, Yazar="Morris"},
            new Kitap("Kaptan Feza", ENUM.Tur.CizgiRoman){SayfaSayisi=50,Yazar="Emre Orhun"},
            new Kitap("İskender", ENUM.Tur.Hikaye){SayfaSayisi=200, Yazar="Sezai Karakoç "},
            new Kitap("Bir Gün", ENUM.Tur.Hikaye){SayfaSayisi=150, Yazar="İsmet Özel"},
            new Kitap("İstanbul Hatırası", ENUM.Tur.Hikaye){SayfaSayisi=300,Yazar="Ahmet Ümit"}
         };

        public void KitaplariListele(ComboBox combo)
        {
            combo.Items.Clear();
            foreach (Kitap item in MevcutKitaplar)
            {
              
                combo.Items.Add(item);
            }
        }
    }
}

