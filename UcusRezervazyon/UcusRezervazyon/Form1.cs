using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcusRezervazyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Rota: " + combonereden.Text + " - " + combonereye.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedsaat.Text + "  -- Yolcu Bilgileri --  " + " İsim Soyisim: " + textadsoyad.Text + " TCKN: " + maskedTC.Text + " Telefon: " + maskedTelefon.Text);
        }

        private void buttondegistir_Click(object sender, EventArgs e)
        {
            label9.Text = combonereye.Text;
            combonereye.Text = combonereden.Text;
            combonereden.Text = label9.Text;
        }
    }
}
