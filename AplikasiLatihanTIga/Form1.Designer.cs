
namespace AplikasiLatihanTIga
{
    partial class frmLatihanTiga3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNama1 = new System.Windows.Forms.Label();
            this.lblPendidikan1 = new System.Windows.Forms.Label();
            this.lblPekerjaan1 = new System.Windows.Forms.Label();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.cmbPendidikan1 = new System.Windows.Forms.ComboBox();
            this.txtNama1 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNama1
            // 
            this.lblNama1.AutoSize = true;
            this.lblNama1.Location = new System.Drawing.Point(22, 21);
            this.lblNama1.Name = "lblNama1";
            this.lblNama1.Size = new System.Drawing.Size(35, 13);
            this.lblNama1.TabIndex = 0;
            this.lblNama1.Text = "Nama";
            // 
            // lblPendidikan1
            // 
            this.lblPendidikan1.AutoSize = true;
            this.lblPendidikan1.Location = new System.Drawing.Point(22, 49);
            this.lblPendidikan1.Name = "lblPendidikan1";
            this.lblPendidikan1.Size = new System.Drawing.Size(60, 13);
            this.lblPendidikan1.TabIndex = 1;
            this.lblPendidikan1.Text = "Pendidikan";
            // 
            // lblPekerjaan1
            // 
            this.lblPekerjaan1.AutoSize = true;
            this.lblPekerjaan1.Location = new System.Drawing.Point(22, 77);
            this.lblPekerjaan1.Name = "lblPekerjaan1";
            this.lblPekerjaan1.Size = new System.Drawing.Size(55, 13);
            this.lblPekerjaan1.TabIndex = 2;
            this.lblPekerjaan1.Text = "Pekerjaan";
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(106, 71);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(258, 82);
            this.lstPekerjaan.TabIndex = 9;
            // 
            // cmbPendidikan1
            // 
            this.cmbPendidikan1.FormattingEnabled = true;
            this.cmbPendidikan1.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.cmbPendidikan1.Location = new System.Drawing.Point(106, 44);
            this.cmbPendidikan1.Name = "cmbPendidikan1";
            this.cmbPendidikan1.Size = new System.Drawing.Size(258, 21);
            this.cmbPendidikan1.TabIndex = 8;
            // 
            // txtNama1
            // 
            this.txtNama1.Location = new System.Drawing.Point(106, 18);
            this.txtNama1.Name = "txtNama1";
            this.txtNama1.Size = new System.Drawing.Size(258, 20);
            this.txtNama1.TabIndex = 3;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(15, 189);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(349, 20);
            this.txtPesan2.TabIndex = 5;
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(3, 3);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(349, 20);
            this.txtPesan1.TabIndex = 4;
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(15, 215);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(349, 20);
            this.txtPesan3.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 241);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(349, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 145);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtPesan1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 105);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // frmLatihanTiga3
            // 
            this.ClientSize = new System.Drawing.Size(378, 272);
            this.Controls.Add(this.lstPekerjaan);
            this.Controls.Add(this.cmbPendidikan1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPesan3);
            this.Controls.Add(this.txtPesan2);
            this.Controls.Add(this.txtNama1);
            this.Controls.Add(this.lblPekerjaan1);
            this.Controls.Add(this.lblPendidikan1);
            this.Controls.Add(this.lblNama1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmLatihanTiga3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latihan 3.3";
            this.MaximumSizeChanged += new System.EventHandler(this.frmLatihanTiga3_Load);
            this.Load += new System.EventHandler(this.frmLatihanTiga3_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        
        
        
        
        
        
        
        
        
        private System.Windows.Forms.Label lblNama1;
        private System.Windows.Forms.Label lblPendidikan1;
        private System.Windows.Forms.Label lblPekerjaan1;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.ComboBox cmbPendidikan1;
        private System.Windows.Forms.TextBox txtNama1;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

