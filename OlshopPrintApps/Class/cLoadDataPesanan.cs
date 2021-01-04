namespace OlshopPrintApps.Class
{   
    public class cLoadDataPesanan
    {
        public string USERNAME{ get; set; }
        public string ALAMAT { get; set; }
        public string USEREMAIL { get; set; }
        public string USERPHONE { get; set; }
        public string QTY { get; set; }
        public string TOTALHARGA { get; set; }
        public string DT { get; set; }
        public string PRINTSTATUS { get; set; }

        public cLoadDataPesanan()
        { }

        public cLoadDataPesanan(string username, string alamat, string useremail, string userphone, string qty,
                                string totalharga, string dt, string printstatus)
        {
            this.USERNAME = username;
            this.ALAMAT = alamat;
            this.USEREMAIL = useremail;
            this.USERPHONE = userphone;
            this.QTY = qty;
            this.TOTALHARGA = totalharga;
            this.DT = dt;
            this.PRINTSTATUS = printstatus;
        }
    }

}
