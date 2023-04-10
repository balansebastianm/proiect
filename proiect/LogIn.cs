using proiect.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace proiect
{
    public partial class LogIn : Form
    {
        string EmailAddr, MFCode;
        public LogIn()
        {
            InitializeComponent();
        }

        private bool CheckData()
        {
            using (ApplicationDbContext dbContexts = new ApplicationDbContext())
            {
                var user = dbContexts.Users.FirstOrDefault(i => i.Email == tbEmail.Text);
                if (user != null)
                {
                    //email bun, verificam parola
                    Register r = new Register();

                    if (r.CheckPassword(tbParola.Text, user.Salt, user.Password))
                    {
                        dbContexts.SaveChanges();
                        MessageBox.Show("Autentificarea a avut loc cu succes. Verifica emailul.");
                        return true;
                    }
                    MessageBox.Show("Parola gresita.");
                    return false;
                }
                MessageBox.Show("Contul nu a fost gasit.");
                return false;
            }

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Closed += (s, args) => this.Close();
            r.Show();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {

            //verificare date de conectare
            if (CheckData())
            {

                Random rd = new Random();
                const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789";
                char[] chars = new char[7];
                for (int i = 0; i < 7; i++)
                {
                    chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
                }
                this.EmailAddr = tbEmail.Text.ToString();
                MFCode = new String(chars);
                MailManager m = new MailManager();
                m.SendMail(EmailAddr,
                    "Codul pentru autentificare",
                    "Folosti urmatorul cod pentru a completa autentificarea:\n",
                    MFCode,
                    "Administrator",
                    "Sistem",
                    "Nume",
                    "Prenume");
                using (ApplicationDbContext dbContexts = new ApplicationDbContext())
                {
                    var user = dbContexts.Users.FirstOrDefault(i => i.Email == tbEmail.Text);
                    user.TwoFactorKey = MFCode;
                    user.TwoFactorCreatedOn = DateTime.UtcNow;
                    var timer = new System.Timers.Timer(1 * 60 * 1000); // 30 minutes
                    timer.Elapsed += Timer_Elapsed;
                    timer.Start();
                    dbContexts.SaveChanges();
                }
                this.Hide();
                Enter2FA fa = new Enter2FA(tbEmail.Text);
                fa.Closed += (s, args) => this.Close();
                fa.Show();
            }
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            using (ApplicationDbContext dbContexts = new ApplicationDbContext())
            {
                var currentTime = DateTime.Now;
                var thirtyMinutesAgo = currentTime.AddMinutes(-30);

                var recordsToDelete = dbContexts.Users.Where(x => x.TwoFactorCreatedOn < thirtyMinutesAgo).ToList();
                foreach (var record in recordsToDelete)
                {
                    record.TwoFactorKey = null;
                    record.TwoFactorCreatedOn = null;
                }
                MessageBox.Show("Deleted");
                dbContexts.SaveChanges();
            }
        }
    }
}
