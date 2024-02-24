using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
//ReSharper disable all

namespace SinemaSalonuUygulamasi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 50; i++)
            {
                SimpleButton button = new SimpleButton
                {
                    Name = "Buton"+i,
                    Text = (i+1).ToString(),
                    Height = 75,
                    Width = 75,
                    Appearance =
                    {
                        BackColor = Color.Yellow
                    },
                    ButtonStyle = BorderStyles.Flat


                };
                button.Click += Koltuk_Click;
                flowLayoutPanel1.Controls.Add(button);
            }

        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            if (button.Appearance.BackColor == Color.Yellow)
            {
                button.Appearance.BackColor = Color.LawnGreen;
                listBoxRezervasyon.Items.Add(button.Text);
            }
            else if (button.Appearance.BackColor == Color.Red)
            {
                MessageBox.Show("Koltuk Satıldı!");
            }
            else if(button.Appearance.BackColor==Color.LawnGreen)
            {
                button.Appearance.BackColor = Color.Yellow;
                listBoxRezervasyon.Items.Remove(button.Text);
            }
            KontenjanHesapla();
            //object sender burada nesnemizi temsil eder
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sat_Click(object sender, EventArgs e)
        {
            listBoxRezervasyon.Items.Clear();
            foreach (SimpleButton item in flowLayoutPanel1.Controls)
            {
                if (item.Appearance.BackColor == Color.LawnGreen)
                {
                    item.Appearance.BackColor = Color.Red;
                }
            }
            KontenjanHesapla();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBoxRezervasyon.Items.Clear();
            foreach (SimpleButton item in flowLayoutPanel1.Controls)
            {
                if (item.Appearance.BackColor == Color.LawnGreen)
                {
                    item.Appearance.BackColor = Color.Yellow;
                }
            }
        }

        
        void KontenjanHesapla()
        {
            int satilan = 0;
            foreach (SimpleButton item in flowLayoutPanel1.Controls)
            {
                if (item.Appearance.BackColor == Color.Red)
                {
                    satilan++;
                }
            }

            txt_satilanKoltukSayisi.Value = satilan;
            txt_kalanKoltukSayisi.Value = 50 - satilan;
            txt_koltukSayisi.Value = listBoxRezervasyon.ItemCount;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (SimpleButton item in flowLayoutPanel1.Controls)
            {
                if (item.Appearance.BackColor == Color.Red)
                {
                    item.Appearance.BackColor = Color.Yellow;
                }
            }
        }
    }
}
