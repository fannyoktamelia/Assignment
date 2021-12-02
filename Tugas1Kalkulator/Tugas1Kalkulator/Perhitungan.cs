using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator08
{
    public partial class Perhitungan : Form
    {
        public delegate void EventHandler(Kalkulator kalculator);
        public event EventHandler OnCalculator;

        private Kalkulator kalkulator;
        public Perhitungan()
        {
            InitializeComponent();
        }

        public Perhitungan(string title) : this()
        {
            this.Text = title;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            kalkulator = new Kalkulator();
            int a = Convert.ToInt32(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);

       
                if(cmbOP.Text == "Penjumlahan")
                    kalkulator.Result = string.Format("Hasil Penjumlahan {0} + {1} = {2}", a, b, a + b);

                if(cmbOP.Text == "Pengurangan")
                kalkulator.Result = string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, a - b);

                if(cmbOP.Text == "Perkalian")
                kalkulator.Result = string.Format("Hasil Perkalian {0} x {1} = {2}", a, b, a * b);

                if(cmbOP.Text == "Pembagian")
                kalkulator.Result = string.Format("Hasil Pembagian {0} / {1} = {2}", a, b, a / b);

     


            OnCalculator(kalkulator);
            txtNilaiA.Clear();
            txtNilaiB.Clear();
            txtNilaiA.Focus();
        }

        private void Perhitungan_Load(object sender, EventArgs e)
        {

        }
    }
}
