using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proiect
{
    public partial class LogIn : Form
    {
        string EmailAddr, MFCode;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {

            //verificare date de conectare
            Random rd = new Random();
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789";
            char[] chars = new char[7];
            for (int i = 0; i < 7; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }
            this.EmailAddr = tbEmail.Text.ToString();
            MFCode = new String(chars);
            MessageBox.Show(MFCode);
            MailManager m = new MailManager();
            m.SendMail(EmailAddr,
                "Codul pentru autentificare",
                "Folosti urmatorul cod pentru a completa autentificarea:\n",
                MFCode,
                "Administrator",
                "Sistem",
                "Nume",
                "Prenume");
            
            Form1 f = new Form1(MFCode);
            f.Show();
            this.Hide();
        }
    }
}
