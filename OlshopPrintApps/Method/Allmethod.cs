using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OlshopPrintApps.Method
{    
    public class Allmethod
    {
        core c;
        public Allmethod(core _c)
        {
            c = _c;
        }
        public DataTable CreateDataTableInventoryReport(DataGridView a)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in a.Columns)
            {
                dt.Columns.Add(col.Name.ToString());
            }
            foreach (DataGridViewRow row in a.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            return dt;
        }
        public  ExcelWorksheet CreateSheet(ExcelPackage p, string sheetName)
        {
            p.Workbook.Worksheets.Add(sheetName);
            ExcelWorksheet ws = p.Workbook.Worksheets[1];
            ws.Name = sheetName; //Setting Sheet's name
            ws.Cells.Style.Font.Size = 11; //Default font size for whole sheet
            ws.Cells.Style.Font.Name = "Calibri"; //Default Font name for whole sheet
            //ws.Protection.IsProtected = false;
            //ws.Protection.SetPassword("shipmentreport");
            ws.PrinterSettings.Orientation = eOrientation.Portrait;
            ws.PrinterSettings.PaperSize = ePaperSize.A4;
            return ws;
        }
        public  void SetWorkbookProperties(ExcelPackage p)
        {
            //Here setting some document properties
            //p.Workbook.Properties.Author = currentUser;
            p.Workbook.Properties.Title = "DATA DAFTAR PESANAN";
            p.Workbook.Properties.Category = "LAPORAN DATA";
            p.Workbook.Properties.Created = DateTime.Now;
        }
        public  void CreateHeader(ExcelWorksheet ws, ref int rowIndex, DataTable dt)
        {
            int colIndex = 1;
            foreach (DataColumn dc in dt.Columns) //Creating Headings
            {
                var cell = ws.Cells[rowIndex, colIndex];

                //Setting the background color of header cells to Gray
                var fill = cell.Style.Fill;
                fill.PatternType = ExcelFillStyle.Solid;
                fill.BackgroundColor.SetColor(Color.DarkGray);

                cell.Style.Font.Bold = true;
                cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                //Setting Top/left,right/bottom borders.
                var border = cell.Style.Border;
                border.Bottom.Style = border.Top.Style = border.Left.Style = border.Right.Style = ExcelBorderStyle.Thin;

                //Setting Value in cell
                cell.Value = dc.ColumnName;

                colIndex++;
            }
        }
        public void ColourLooping(ExcelWorksheet ws, DataTable dt, ProgressBar pb)
        {
            int rowSet = 2;
            pb.Maximum = dt.Rows.Count;
            pb.Value = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (rowSet % 2 == 0)
                {
                    ws.Cells[rowSet, 1, rowSet, dt.Columns.Count].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[rowSet, 1, rowSet, dt.Columns.Count].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                }
                rowSet++;
                pb.Value++;
            }
            var border = ws.Cells[1, 1, dt.Rows.Count + 1, dt.Columns.Count].Style.Border;
            border.BorderAround(ExcelBorderStyle.Thin);
            ws.Cells.AutoFitColumns();
        }
        public void ExportToExcell(ComboBox cb, ProgressBar pb, DataGridView dgv)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "DAFTAR DATA PESANAN";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    FileInfo newfile = new FileInfo(saveFileDialog.FileName);

                    if (newfile.Exists)
                    {
                        File.Delete(newfile.FullName);
                    }

                    using (ExcelPackage pck = new ExcelPackage(newfile))
                    {
                        //DataTable dt = c.getLoadDataPesanan(cb.Text);
                        DataTable dt = null;

                        c.getSetWorkbookProperties(pck);
                        ExcelWorksheet ws = c.getCreateSheet(pck, "DAFTAR DATA PESANAN");
                        int rowindex = 1;
                        c.getCreateHeader(ws, ref rowindex, dt);
                        ws.Cells["A1"].LoadFromDataTable(dt, true);
                        c.getColourLooping(ws, dt, pb);
                        pck.Save();
                        MessageBox.Show("EXPORTING FILE TO EXCEL IS SUCCESS");
                    }
                    pb.Value = 0;
                    dgv.DataSource = null;
                    cb.SelectedIndex = -1;
                    cb.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXPORTING FILE TO EXCEL IS FAILED. EXCEPTION: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void SearchDataPesanan(DataGridView a, DateTime dt)
        {
            a.DataSource = c.getLoadDataPesanan(dt);
        }

    }
}
