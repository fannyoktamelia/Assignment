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
    public partial class HasilHitung : Form
    {
        private List<Kalkulator> listDariHasil = new List<Kalkulator>();
        public HasilHitung()
        {
            InitializeComponent();
            initialisasilv();
        }

        private void initialisasilv()
        {
            lvHasil.View = View.Details;

            lvHasil.Columns.Add("", 10, HorizontalAlignment.Left);
            lvHasil.Columns.Add("", 200, HorizontalAlignment.Left);


        }
        private void Frmcalc_OnCalculated(Kalkulator kalkulator)
        {
            listDariHasil.Add(kalkulator);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(kalkulator.Result);

            lvHasil.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perhitungan perhitungan = new Perhitungan("Calculator");
            perhitungan.OnCalculator += Frmcalc_OnCalculated;
            perhitungan.ShowDialog();
        }

        private void HasilHitung_Load(object sender, EventArgs e)
        {

        }
    }
}
