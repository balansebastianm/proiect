using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;
using PacketDotNet;
using SharpPcap;

namespace proiect
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void blocksite_btn_Click(object sender, EventArgs e)
        {
            string siteToBlock = siteTBox.Text;
            string hostsFilePath = Environment.SystemDirectory + @"\drivers\etc\hosts";
            string blockEntry = $"127.0.0.1 {siteToBlock}";

            if (!File.ReadAllLines(hostsFilePath).Contains(blockEntry))
            {
                using (StreamWriter writer = File.AppendText(hostsFilePath))
                {
                    writer.WriteLine(blockEntry);
                }

                MessageBox.Show($"Site-ul {siteToBlock} a fost blocat cu succes");
            }
            else
            {
                MessageBox.Show($"Site-ul {siteToBlock} este deja blocat");
            }
        }

        private void deblocaresite_btn_Click(object sender, EventArgs e)
        {
            string siteToUnblock = siteTBox.Text;
            string hostsFilePath = Environment.SystemDirectory + @"\drivers\etc\hosts";
            string blockEntry = $"127.0.0.1 {siteToUnblock}";

            string[] lines = File.ReadAllLines(hostsFilePath);
            if (lines.Contains(blockEntry))
            {
                string[] newLines = lines.Where(line => line != blockEntry).ToArray();
                File.WriteAllLines(hostsFilePath, newLines);

                MessageBox.Show($"Site-ul {siteToUnblock} a fost deblocat");
            }
            else
            {
                MessageBox.Show($"Site-ul {siteToUnblock} nu este blocat");
            }
        }
        private void CapturePackets_Click(object sender, EventArgs e)
        {
            CapturePackets c = new CapturePackets();
            this.Hide();
            c.Show();
            c.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            this.FormClosed += new FormClosedEventHandler(ParentClosed);
        }
        void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void ParentClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
