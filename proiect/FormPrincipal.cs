using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPcap;

namespace proiect
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            var devices = CaptureDeviceList.Instance;


            var device = devices[0];


            device.Open(DeviceMode.Promiscuous);


            device.Filter = "tcp port 80";


            device.OnPacketArrival += OnPacketArrival;

            device.StartCapture();

            listBox1.DisplayMember = "Description";

            MessageBox.Show("Click OK to stop capturing...");

            device.StopCapture();

            device.Close();

        }

        private void OnPacketArrival(object sender, CaptureEventArgs e)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action(() =>
                {
                    listBox1.Items.Add($"[{e.Packet.Timeval.Date}] {e.Packet.ToString()}");
                }));
            }
            else
            {
                listBox1.Items.Add($"[{e.Packet.Timeval.Date}] {e.Packet.ToString()}");
            }

            Console.WriteLine($"[{e.Packet.Timeval.Date}] {e.Packet.ToString()}");
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

        
    }
}
