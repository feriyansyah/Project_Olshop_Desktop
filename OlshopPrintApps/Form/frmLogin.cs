using OlshopPrintApps.Method;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OlshopPrintApps
{
    public partial class frmLogin : Form
    {
        core c;
        public frmLogin(core _c)
        {
            c = _c;
            InitializeComponent();
            btClose.Click += BtClose_Click;
            txtEmail.KeyDown += TxtUsername_KeyDown;
            txtPassword.KeyDown += TxtPassword_KeyDown;
            btnLogin.Click += BtnLogin_Click;
            this.Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        #region loadPassEncrypt

        //void frmLogin_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show(Encryptor.Encrypt("f", null));
        //    // MNeHFic9El/GaB/n8fmBYCeZlobQ/Fm6kDSz
        //    MessageBox.Show("Sukses gan");
        //}

        #endregion

        #region Event

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtEmail.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, null);
            }
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            #region DefaultCode

            try
            {
                //LINQ untuk LOGIN  
                //KHUSUS ADMIN YG BISA AKSES
                string email = c.getLoadUserAccess().FirstOrDefault(x => x.EMAIL.ToUpper() == txtEmail.Text.ToUpper()).EMAIL.ToUpper();

                if ((email != string.Empty && email == txtEmail.Text.ToUpper()))
                {
                    string pass = c.getLoadUserAccess().FirstOrDefault(x => x.EMAIL.ToUpper() == txtEmail.Text.ToUpper()).PASSWORD;
                    //if (Encryptor.VerifyHash(txtPassword.Text, c.getLoadUserAccess().FirstOrDefault(x => x.EMAIL.ToUpper() == txtEmail.Text.ToUpper()).PASSWORD))
                    if (pass == txtPassword.Text)
                    {
                        string username = c.getLoadUserAccess().FirstOrDefault(x => x.EMAIL.ToUpper() == txtEmail.Text.ToUpper()).USERNAME;

                        this.ShowInTaskbar = false;
                        frmOlshopPrintApps show = new frmOlshopPrintApps(c, username);
                        show.Show();
                    }
                    else
                    {
                        MessageBox.Show("WRONG PASSWORD !", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Clear();
                        txtPassword.Clear();
                        txtEmail.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMAIL NOT EXIST/VALID", "INFROMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }

            #endregion

            #region New Code
            //try
            //{                
            //    string a = "ADMIN";
            //    if (a == txtUsername.Text.ToUpper())
            //    {
            //        if (Encryptor.VerifyHash(txtPassword.Text, "MNeHFic9El/GaB/n8fmBYCeZlobQ/Fm6kDSz"))
            //        {
            //            string userid = a;

            //            this.ShowInTaskbar = false;
            //            frmOlshopPrintApps show = new frmOlshopPrintApps(c);
            //            show.Show();
            //        }
            //        else
            //        {
            //            MessageBox.Show("USER ID IS WRONG", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            txtUsername.Clear();
            //            txtPassword.Clear();
            //            txtUsername.Focus();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("USER ID IS WRONG", "INFROMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtUsername.Clear();
            //        txtPassword.Clear();
            //        txtUsername.Focus();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("USER ID IS WRONG", "INFROMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtUsername.Clear();
            //    txtPassword.Clear();
            //    txtUsername.Focus();
            //}
            #endregion
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("EXIT ?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            { Application.Exit(); }
            else
            {
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }
        }

        #endregion
    }
}
