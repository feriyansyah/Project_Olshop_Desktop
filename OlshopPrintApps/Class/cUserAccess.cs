namespace OlshopPrintApps.Class
{
    public class cUserAccess
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        
        public cUserAccess()
        { }

        public cUserAccess(string username, string password, string email)
        {
            this.USERNAME = username;
            this.PASSWORD = password;
            this.EMAIL = email;
        }
    }
}
