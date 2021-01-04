namespace OlshopPrintApps
{
    partial class frmOlshopPrintApps
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExports = new System.Windows.Forms.Button();
            this.progressBars1 = new System.Windows.Forms.ProgressBar();
            this.lblOlshopName = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.btCari = new System.Windows.Forms.Button();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDaftarPesanan = new System.Windows.Forms.GroupBox();
            this.dgDaftarPesanan = new System.Windows.Forms.DataGridView();
            this.lblTotalPesanan = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbDaftarPesanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDaftarPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExports
            // 
            this.btnExports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExports.Location = new System.Drawing.Point(867, 292);
            this.btnExports.Name = "btnExports";
            this.btnExports.Size = new System.Drawing.Size(79, 33);
            this.btnExports.TabIndex = 218;
            this.btnExports.Text = "EXPORT";
            this.btnExports.UseVisualStyleBackColor = true;
            this.btnExports.Visible = false;
            // 
            // progressBars1
            // 
            this.progressBars1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBars1.Location = new System.Drawing.Point(0, 171);
            this.progressBars1.Name = "progressBars1";
            this.progressBars1.Size = new System.Drawing.Size(1157, 21);
            this.progressBars1.TabIndex = 222;
            this.progressBars1.Visible = false;
            // 
            // lblOlshopName
            // 
            this.lblOlshopName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOlshopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlshopName.Location = new System.Drawing.Point(0, 0);
            this.lblOlshopName.Name = "lblOlshopName";
            this.lblOlshopName.Size = new System.Drawing.Size(1157, 100);
            this.lblOlshopName.TabIndex = 225;
            this.lblOlshopName.Text = "OLSHOP_NAME";
            this.lblOlshopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.LightCoral;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(1119, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 33);
            this.Close.TabIndex = 226;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 533);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1157, 35);
            this.panel4.TabIndex = 227;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1157, 35);
            this.label4.TabIndex = 228;
            this.label4.Text = "COPYRIGHT © 2021 OLSHOP NAME";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.lblOlshopName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 100);
            this.panel1.TabIndex = 228;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.LightCoral;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1078, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 33);
            this.btnMinimize.TabIndex = 227;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 100);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1157, 7);
            this.panel10.TabIndex = 229;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtTanggal);
            this.panel2.Controls.Add(this.btCari);
            this.panel2.Controls.Add(this.lblTanggal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 58);
            this.panel2.TabIndex = 215;
            // 
            // dtTanggal
            // 
            this.dtTanggal.CustomFormat = "yyyyMMdd HHmm";
            this.dtTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTanggal.Location = new System.Drawing.Point(12, 25);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(270, 22);
            this.dtTanggal.TabIndex = 220;
            // 
            // btCari
            // 
            this.btCari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCari.Location = new System.Drawing.Point(288, 19);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(79, 33);
            this.btCari.TabIndex = 219;
            this.btCari.Text = "CARI";
            this.btCari.UseVisualStyleBackColor = true;
            // 
            // lblTanggal
            // 
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(9, 5);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(79, 18);
            this.lblTanggal.TabIndex = 199;
            this.lblTanggal.Text = "TANGGAL";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1157, 58);
            this.panel6.TabIndex = 230;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(862, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 221;
            this.label1.Text = "Total Pesanan :";
            // 
            // gbDaftarPesanan
            // 
            this.gbDaftarPesanan.Controls.Add(this.dgDaftarPesanan);
            this.gbDaftarPesanan.Location = new System.Drawing.Point(12, 209);
            this.gbDaftarPesanan.Name = "gbDaftarPesanan";
            this.gbDaftarPesanan.Size = new System.Drawing.Size(825, 286);
            this.gbDaftarPesanan.TabIndex = 231;
            this.gbDaftarPesanan.TabStop = false;
            this.gbDaftarPesanan.Text = "DAFTAR PESANAN HARI INI";
            // 
            // dgDaftarPesanan
            // 
            this.dgDaftarPesanan.AllowUserToAddRows = false;
            this.dgDaftarPesanan.AllowUserToDeleteRows = false;
            this.dgDaftarPesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDaftarPesanan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgDaftarPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDaftarPesanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDaftarPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDaftarPesanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDaftarPesanan.Location = new System.Drawing.Point(3, 16);
            this.dgDaftarPesanan.Name = "dgDaftarPesanan";
            this.dgDaftarPesanan.ReadOnly = true;
            this.dgDaftarPesanan.RowHeadersVisible = false;
            this.dgDaftarPesanan.Size = new System.Drawing.Size(819, 267);
            this.dgDaftarPesanan.TabIndex = 222;
            // 
            // lblTotalPesanan
            // 
            this.lblTotalPesanan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPesanan.Location = new System.Drawing.Point(1047, 225);
            this.lblTotalPesanan.Name = "lblTotalPesanan";
            this.lblTotalPesanan.Size = new System.Drawing.Size(98, 25);
            this.lblTotalPesanan.TabIndex = 232;
            this.lblTotalPesanan.Text = "-";
            // 
            // btPrint
            // 
            this.btPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(867, 253);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(79, 33);
            this.btPrint.TabIndex = 221;
            this.btPrint.Text = "PRINT";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(962, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(183, 18);
            this.lblUsername.TabIndex = 221;
            this.lblUsername.Text = "-";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1066, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 233;
            this.label2.Text = "ADMIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmOlshopPrintApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 568);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.lblTotalPesanan);
            this.Controls.Add(this.gbDaftarPesanan);
            this.Controls.Add(this.btnExports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.progressBars1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOlshopPrintApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHIPMENT REPORT";
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.gbDaftarPesanan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDaftarPesanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExports;
        private System.Windows.Forms.ProgressBar progressBars1;
        private System.Windows.Forms.Label lblOlshopName;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDaftarPesanan;
        private System.Windows.Forms.DataGridView dgDaftarPesanan;
        private System.Windows.Forms.Label lblTotalPesanan;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
    }
}

