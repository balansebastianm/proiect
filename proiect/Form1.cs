using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form1 : Form
    {
        private string MFCode;
        private int IncercariRamase = 5;

        public Form1(string MFCode)
        {
            this.MFCode = MFCode;
            InitializeComponent();
        }

        private void btSend2FA_Click(object sender, EventArgs e)
        {
            if(tb2FA.Text.ToString() == MFCode)
            {
                MessageBox.Show("Autentificarea a avut loc cu succes");
            }
            else
            {
                IncercariRamase--;
                if (IncercariRamase == 0) {
                    MessageBox.Show("Nu mai aveti incercari ramase.");
                    //sterge codul din baza de date
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
