using OlshopPrintApps.Class;
using System.Collections.Generic;
using System.Data;

namespace OlshopPrintApps.Query
{
    public class Allquery
    {
        core c;
        public Allquery(core _c)
        {
            c = _c;
        }
             
        public List<cUserAccess> LoadUserAccess()
        {
            DataTable dt = c.S(string.Format(@"SELECT username,password,email from Admin WHERE active=1"));
            return c.ConvertTo<cUserAccess>(dt);
        }      
      
        public List<cLoadDataPesanan> LoadDataPesanan(string tanggal)
        {
            //DataTable dt = c.S(string.Format(@"exec SP_GetDataOlshopByDate '{0}'", tanggal)); //MySQL ga bisa pakai SP
            DataTable dt = c.S(string.Format(@"SELECT* FROM users WHERE dt BETWEEN '{0} 00:00' AND '{0} 23:59' order by dt DESC", tanggal));            
            return c.ConvertTo<cLoadDataPesanan>(dt);
        }                
    }
}
