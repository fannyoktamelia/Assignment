using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTIga
{
    public partial class frmLatihanTiga3 : Form
    {
        public frmLatihanTiga3()
        {
            InitializeComponent();
        }

        private void frmLatihanTiga3_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama1.Text;
            var pendidikan = cmbPendidikan1.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo {0}", nama);
            txtPesan2.Text = string.Format("Pendidikan anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Anda seorang {0}, Hebat!", pekerjaan);

        }

        private void lstPekerjaan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
