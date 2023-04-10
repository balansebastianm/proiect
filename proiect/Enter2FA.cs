using proiect.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace proiect
{
    public partial class Enter2FA : Form
    {
        private string Email;
        private int IncercariRamase = 5;

        public Enter2FA(string Email)
        {
            this.Email = Email;
            InitializeComponent();
        }

        private void btSend2FA_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext dbContexts = new ApplicationDbContext())
            {
                var user = dbContexts.Users.FirstOrDefault(i => i.Email == Email);
                string TwoFactorCode = user.TwoFactorKey;
                Debug.WriteLine(TwoFactorCode);
                if (tb2FA.Text.ToString() == TwoFactorCode)
                {
                    MessageBox.Show("Autentificarea a avut loc cu succes");
                }
                else
                {
                    IncercariRamase--;
                    if (IncercariRamase == 0)
                    {
                        MessageBox.Show("Nu mai aveti incercari ramase.");
                        //sterge codul din baza de date
                        user.TwoFactorKey = null;
                        dbContexts.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cod invalid. Mai aveti " + IncercariRamase + " incercari ramase");
                    }
                }
            }
        }
    }
}
