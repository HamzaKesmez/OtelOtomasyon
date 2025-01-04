using OtelOtomasyon.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class FormOdalar : Form
    {
        public FormOdalar()
        {
            InitializeComponent();
            OdalariListele();
        }
        private void OdalariListele()
        {
            using (var context = new OtelContext())
            {
                var odalar = context.Odalar.ToList();
                int x = 10, y = 10, katNo = 1;
                int buttonWidth = 50, buttonHeight = 50, spacing = 10;

                foreach (var oda in odalar.OrderBy(o => o.KatNo).ThenBy(o => o.OdaNo))
                {
                    if (oda.KatNo != katNo)
                    {
                        katNo = oda.KatNo;
                        y += buttonHeight + spacing;
                        x = 10;
                    }

                    Button odaButton = new Button();
                    odaButton.Width = buttonWidth;
                    odaButton.Height = buttonHeight;
                    odaButton.Text = oda.OdaNo.ToString();
                    odaButton.BackColor = oda.Durum == "Dolu" ? Color.Red : Color.Green;
                    odaButton.Location = new Point(x, y);

                    // Tıklama olayını oda bilgilerini göstermek için bağlayın
                    odaButton.Click += (s, e) => OdaBilgileriniGoster(oda);

                    x += buttonWidth + spacing;
                    panelOdalar.Controls.Add(odaButton);
                }
            }
        }
        private void OdaBilgileriniGoster(Oda oda)
        {
            // bilgiPanel içindeki bilgi gösterecek alanların Text özelliklerini ayarlayın
            lblOdaNo.Text = "Oda No: " + oda.OdaNo;
            lblKatNo.Text = "Kat No: " + oda.KatNo;
            lblYatakSayisi.Text = "Yatak Sayısı: " + oda.YatakSayisi;
            lblFiyat.Text = "Fiyat: " + oda.Fiyat.ToString("C");
            lblDurum.Text = "Durum: " + oda.Durum;
        }

        private void FormOdalar_Load(object sender, EventArgs e)
        {

        }
    }
}
