using proiect.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private bool CheckEmail(string Email)
        {
            try
            {
                MailAddress m = new MailAddress(Email);
                return true;
            } catch(FormatException)
            {
                return false;
            }
           
        }
        public static string HashPassword(string password, string salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);

            byte[] saltedPassword = new byte[passwordBytes.Length + saltBytes.Length];
            Array.Copy(passwordBytes, saltedPassword, passwordBytes.Length);
            Array.Copy(saltBytes, 0, saltedPassword, passwordBytes.Length, saltBytes.Length);

            HashAlgorithm hashAlgorithm = new SHA256Managed();
            byte[] hashedPasswordBytes = hashAlgorithm.ComputeHash(saltedPassword);

            return Convert.ToBase64String(hashedPasswordBytes);
        }
        public static string GetRandomSalt(int size)
        {
            byte[] salt = new byte[size];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }
        public bool CheckPassword(string password, string salt, string hashedPassword)
        {
            string hashedPasswordToCheck = HashPassword(password, salt);
            return hashedPassword == hashedPasswordToCheck;
        }
        private bool CheckPasswordStrength(string password)
        {
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            return validateGuidRegex.IsMatch(password);
        }
        private void btRegister_Click(object sender, EventArgs e)
        {

            string AdresaEmail = tbEmail.Text;
            string Password = tbPassword.Text;
            string SaltValue = GetRandomSalt(32);
            string HashedPassword = HashPassword(Password, SaltValue);
            if (!CheckEmail(AdresaEmail))
            {
                MessageBox.Show("Adresa de email este invalida.");
                return;
            }
            if(!CheckPasswordStrength(Password))
            {
                MessageBox.Show("Parola trebuie sa contina cel putin 8 caractere printre care o litera mare, o litera mica, o cifra si un caracter special.");
                return;
            }
            using(ApplicationDbContext dbContext = new ApplicationDbContext()) {
                var user = dbContext.Users.FirstOrDefault(i => i.Email == tbEmail.Text);
                if(user != null)
                {
                    MessageBox.Show("Adresa de email exista deja.");
                    return;
                }
                User u = new User()
                {
                    Email = AdresaEmail,
                    Password = HashedPassword,
                    Salt = SaltValue
                };
                try
                {
                    dbContext.Users.Add(u);
                    dbContext.SaveChanges();
                    MessageBox.Show("Inregistrare efectuata cu succes.");
                    this.Hide();
                    LogIn l = new LogIn();
                    l.Closed += (s, args) => this.Close();
                    l.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        
            
    }
}
