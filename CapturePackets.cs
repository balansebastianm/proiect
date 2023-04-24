using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace proiect
{
    public partial class CapturePackets : Form
    {
        CaptureDeviceList devices = CaptureDeviceList.Instance;
        ICaptureDevice device;
        List<string> Payload = new List<string>();
        
        public CapturePackets()
        {

            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(CloseForm);
            
            CaptureInit();
        }
        void CloseForm(object sender, FormClosedEventArgs e)
        {
            StopCaptureF();
        }
        private void CaptureInit()
        {
            device = devices[0];
            device.Open(DeviceMode.Promiscuous);
            device.OnPacketArrival += OnPacketArrival;
            device.StartCapture();
            Results.Items.Add("-----------------------------------------------------------------------------------");
            Payload.Add("Header");
            Results.Items.Add(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ": " + $"Started capturing on {device.Description}");
            Payload.Add("Header");
        }
        private void OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            var tcpPacket = TcpPacket.GetEncapsulated(packet);
            var udpPacket = UdpPacket.GetEncapsulated(packet);
            var ipPacket = IpPacket.GetEncapsulated(packet);
            WriteToBox(tcpPacket, udpPacket, ipPacket, packet);
        }
        private void WriteToBox(TcpPacket tcpPacket, UdpPacket udpPacket, IpPacket ipPacket, Packet packet)
        {
            if (tcpPacket != null)
            {
                AddToPayload(tcpPacket.PayloadData);
                Results.Invoke(new Action(() => Results.Items.Add(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ": " + $"TCP packet from {ipPacket.SourceAddress}:{tcpPacket.SourcePort} to {ipPacket.DestinationAddress}:{tcpPacket.DestinationPort}")));
            }
            else if (udpPacket != null)
            {
                AddToPayload(udpPacket.PayloadData);
                Results.Invoke(new Action(() => Results.Items.Add(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ": " + $"UDP packet from {ipPacket.SourceAddress}:{udpPacket.SourcePort} to {ipPacket.DestinationAddress}:{udpPacket.DestinationPort}")));
            }
            else if (ipPacket != null)
            {
                AddToPayload(ipPacket.PayloadData);
                Results.Invoke(new Action(() => Results.Items.Add(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ": " + $"IP packet from {ipPacket.SourceAddress} to {ipPacket.DestinationAddress}")));
            }
            else
            {
                AddToPayload(packet.PayloadData);
                Results.Invoke(new Action(() => Results.Items.Add(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ": " + $"Unknown packet: {packet.GetType().Name}")));
            }
        }
        private void AddToPayload(byte[] data)
        {
            string DataToString;
            try
            {
                 DataToString = BitConverter.ToString(data);
            }
            catch
            {
                DataToString = "No payload"; 
            }
            Payload.Add(DataToString);

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            StopCaptureF();
            this.Close();
        }

        private void StopCapture_Click(object sender, EventArgs e)
        {
            StopCaptureF();
        }
        private void SaveToDisk_Click(object sender, EventArgs e)
        {
            StopCaptureF();
            SaveData();
        }
        private void StopCaptureF()
        {
            try
            {
                device.StopCapture();
                device.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }
        private void SaveData()
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var item in Results.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Succes");
            Results.Items.Add(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ": " + "Written to file.");
            Payload.Add("Written to file");
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            CaptureInit();
        }

        private void Results_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.Results.IndexFromPoint(e.Location);
            if (!(index < 0))
            {
                MessageBox.Show(Payload[index]);
            }
            
        }
    }
}
