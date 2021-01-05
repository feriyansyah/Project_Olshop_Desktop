using OlshopPrintApps.Query;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Linq;
using System.Reflection;
using System.Transactions;
using System.Windows.Forms;
using OlshopPrintApps.Class;
using OlshopPrintApps.Method;

using OfficeOpenXml;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;

namespace OlshopPrintApps
{
    public class core
    {
        Allquery AQ;
        Allmethod AM;
        public Process pp = new Process();
        public string conStr { get; set; }

        public core()
        {
            conStr = ConfigurationSettings.AppSettings["DB"].ToString();
            AQ = new Allquery(this);
            AM = new Allmethod(this);
        }
        public DataTable S(string q)
        {
            DataTable temp = new DataTable();
            if (q == null || q == "")
                return temp;
            try
            {
                //versi SQL Server
                //using (SqlConnection con = new SqlConnection(conStr))
                //{
                //    con.Open();
                //    using (SqlCommand cmd = new SqlCommand(q, con))
                //    {
                //        cmd.CommandTimeout = 100;
                //        using (SqlDataReader read = cmd.ExecuteReader())
                //        {
                //            temp.Load(read);
                //        }
                //    }
                //}

                //Versi MySQL
                using (MySqlConnection con = new MySqlConnection(conStr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(q, con))
                    {
                        cmd.CommandTimeout = 60000;
                        using (MySqlDataReader read = cmd.ExecuteReader())
                        {
                            temp.Load(read);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return temp;
        }
        public bool CUD(string q)
        {
            bool temp = false;
            if (q == null || q == "")
                return temp;
            try
            {
                using (TransactionScope trans = new TransactionScope())
                {
                    //Versi MySQL
                    using (MySqlConnection con = new MySqlConnection(conStr))
                    {
                        con.Open();
                        using (MySqlCommand cmd = new MySqlCommand(q, con))
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                temp = true;
                            }
                        }
                    }
                    trans.Complete();
                }
            }
            catch { }
            return temp;
        }
        public void killLppa()
        {
            pp.StartInfo.UseShellExecute = false;
            pp.StartInfo.RedirectStandardOutput = true;
            pp.StartInfo.CreateNoWindow = true;
            pp.StartInfo.FileName = "cmd.exe";
            pp.StartInfo.Arguments = "/c TASKKILL /F /IM lppa.exe /T";
            try
            {
                using (Process ex = Process.Start(pp.StartInfo))
                {
                    ex.WaitForExit();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region ini function untuk convert ke List

        public List<T> ConvertTo<T>(DataTable datatable) where T : new()
        {
            List<T> Temp = new List<T>();
            try
            {
                List<string> columnsNames = new List<string>();
                foreach (DataColumn DataColumn in datatable.Columns)
                    columnsNames.Add(DataColumn.ColumnName);
                Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames));
                return Temp;
            }
            catch
            {
                return Temp;
            }

        }
        public T getObject<T>(DataRow row, List<string> columnsName) where T : new()
        {
            T obj = new T();
            try
            {
                string columnname = "";
                string value = "";
                PropertyInfo[] Properties;
                Properties = typeof(T).GetProperties();
                foreach (PropertyInfo objProperty in Properties)
                {
                    columnname = columnsName.Find(name => name.ToLower() == objProperty.Name.ToLower());
                    if (!string.IsNullOrEmpty(columnname))
                    {
                        value = row[columnname].ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (Nullable.GetUnderlyingType(objProperty.PropertyType) != null)
                            {
                                value = row[columnname].ToString().Replace("$", "").Replace(",", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(Nullable.GetUnderlyingType(objProperty.PropertyType).ToString())), null);
                            }
                            else
                            {
                                value = row[columnname].ToString().Replace("%", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(objProperty.PropertyType.ToString())), null);
                            }
                        }
                    }
                }
                return obj;
            }
            catch
            {
                return obj;
            }
        }

        #endregion

        #region get function from AllQuery
            
        public List<cUserAccess> getLoadUserAccess()
        {
            return AQ.LoadUserAccess();
        }
        public List<cLoadDataPesanan> getLoadDataPesanan(DateTime tanggal)
        {
            return AQ.LoadDataPesanan(tanggal.ToString("yyyy-MM-dd"));
        }
        
        #endregion

        #region get function from AllMethod
      
        public void getSearchDataPesanan(DataGridView a, DateTime dt)
        {
            AM.SearchDataPesanan(a, dt);
        }

        public DataTable getCreateDataTableInventoryReport(DataGridView a)
        {
            return AM.CreateDataTableInventoryReport(a);
        }
        public ExcelWorksheet getCreateSheet(ExcelPackage p, string sheetName)
        {
            return AM.CreateSheet(p, sheetName);
        }
        public void getSetWorkbookProperties(ExcelPackage p)
        {
            AM.SetWorkbookProperties(p);
        }
        public void getCreateHeader(ExcelWorksheet ws, ref int rowIndex, DataTable dt)
        {
            AM.CreateHeader(ws, ref rowIndex, dt);
        }
        public void getColourLooping(ExcelWorksheet ws, DataTable dt, ProgressBar pb)
        {
            AM.ColourLooping(ws, dt, pb);
        }
        public void getExportToExcell(ComboBox cb, ProgressBar pb, DataGridView dgv)
        {
            AM.ExportToExcell(cb,pb,dgv);
        }
        #endregion
        
    }

    public enum LabelType { PRINTLABEL };
    public class LabelLibrary
    {
        LabelManager2.Application server;
        LabelManager2.Document doc;

        public string getdefaultprinter()
        {
            string output = "";
            PrinterSettings setting = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                setting.PrinterName = printer;
                if (setting.IsDefaultPrinter)
                {
                    output = printer;
                }
            }
            return output;
        }
        public void Close()
        {
            server.Documents.CloseAll();
            server.Quit();
            doc = null;
            server = null;
        }
        public void DocVisible(bool state)
        {
            server.Visible = state;
        }

        public bool Print(LabelType typ, List<String> detail)
        {
            core c = new core();
            bool temp = false;
            server = new LabelManager2.Application();
            doc = new LabelManager2.Document();
            string defaultprinter = getdefaultprinter();
            
            try
            {
                switch (typ)
                {   
                    //PRINT LABEL
                    case LabelType.PRINTLABEL:
                        server.Documents.Open(Application.StartupPath + @"\PRINTLABEL.lab");
                        server.PrinterSystem();
                        doc = server.ActiveDocument;

                        //Nama printer harus sesuai dg Hardware yang dipasang 
                        doc.Printer.SwitchTo(defaultprinter);
                        //doc.Printer.SwitchTo("HP DJ 2130 series");
                        //doc.Printer.SwitchTo("HP LaserJet Professional P1102");

                        doc.Variables.FormVariables.Item("olshopname").Value = detail[0].ToString();
                        doc.Variables.FormVariables.Item("nama").Value = detail[1].ToString();
                        doc.Variables.FormVariables.Item("alamat").Value = detail[2].ToString();
                        doc.Variables.FormVariables.Item("email").Value = detail[3].ToString();
                        doc.Variables.FormVariables.Item("hp").Value = detail[4].ToString();
                        doc.Variables.FormVariables.Item("tanggalpesan").Value = detail[5].ToString();
                        doc.Variables.FormVariables.Item("qty").Value = detail[6].ToString();
                        
                        doc.PrintLabel(1);
                        doc.FormFeed();
                        temp = true;
                        c.killLppa();
                        break;
                }
            }
            catch (Exception ex) { }
            return temp;
        }
    }
}
