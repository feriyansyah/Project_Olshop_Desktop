using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Collections.Generic;

namespace OlshopPrintApps
{

    public partial class frmOlshopPrintApps : Form
    {
        core c;
        string ThisUsername;
        LabelLibrary printlabel = new LabelLibrary();

        string namatoko = string.Empty;
        string nama = string.Empty;
        string alamat = string.Empty;
        string email = string.Empty;
        string hp = string.Empty;
        string tanggalPesan = string.Empty;
        string qty = string.Empty;        

        public frmOlshopPrintApps(core _c, string username)
        {
            c = _c;
            InitializeComponent();
            ThisUsername = username;
            this.Load += frmOlshopPrintApps_Load;
            btnExports.Click += btnExports_Click;
            Close.Click += close_Click;
            btnMinimize.Click += BtnMinimize_Click;
            btCari.Click += BtCari_Click;
            btPrint.Click += BtPrint_Click;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            getDaftarPesanan();
        }

        #region load
        void frmOlshopPrintApps_Load(object sender, EventArgs e)
        {
            dtTanggal.Text = DateTime.Now.ToString();
            lblUsername.Text = ThisUsername;
            getDaftarPesanan();
        }

        #endregion

        #region event
        void btnExports_Click(object sender, EventArgs e)
        {
            if (dgDaftarPesanan.DataSource != null)
            {
                c.getExportToExcell(null, progressBars1, dgDaftarPesanan);
                lblTotalPesanan.Text = "-";
            }
            else
            {
                MessageBox.Show("DATA NOT FOUND", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTanggal.Focus();
            }
        }
        void close_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("EXIT ?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                lblTotalPesanan.Text = "-";
                dtTanggal.Focus();
                dgDaftarPesanan.DataSource = null;

            }
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtPrint_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgDaftarPesanan.Rows)
            {
                namatoko = lblOlshopName.Text;
                nama = item.Cells["USERNAME"].Value.ToString();
                alamat = item.Cells["ALAMAT"].Value.ToString();
                email = item.Cells["USEREMAIL"].Value.ToString();
                hp = item.Cells["USERPHONE"].Value.ToString();
                tanggalPesan = item.Cells["DT"].Value.ToString();
                qty = item.Cells["QTY"].Value.ToString();

                PrintData(email);
            }
            clear();
            MessageBox.Show(string.Format(@"PRINT SUCCESS : {0} Data", dgDaftarPesanan.Rows.Count));

        }
        private void BtCari_Click(object sender, EventArgs e)
        {
            getDaftarPesanan();
        }

        #endregion

        #region method
        public void getDaftarPesanan()
        {
            c.getSearchDataPesanan(dgDaftarPesanan, dtTanggal.Value);
            DataGridViewCellStyle test = new DataGridViewCellStyle();
            test.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDaftarPesanan.ColumnHeadersDefaultCellStyle = test;
            dgDaftarPesanan.DefaultCellStyle = test;
            dgDaftarPesanan.Columns[1].Width = 50;

            lblTotalPesanan.Text = dgDaftarPesanan.RowCount.ToString();
        }
       
        public void PrintData(string email)
        {
            //print label
            List<String> Data = new List<string>();
            Data.Add(namatoko);
            Data.Add(nama);
            Data.Add(alamat);
            Data.Add(email);
            Data.Add(hp);
            Data.Add(tanggalPesan);
            Data.Add(qty);

            if (!printlabel.Print(LabelType.PRINTLABEL, Data))
            {
                dgDaftarPesanan.Focus();
                MessageBox.Show("Data Error");
                return;
            }

            c.CUD(string.Format("update users set printstatus=1 where email='{0}'", email));
        }
        public void clear()
        {
            dgDaftarPesanan.Focus();
        }
        
        #endregion
    }
}
