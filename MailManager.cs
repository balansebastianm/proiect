using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using MimeKit;

namespace proiect
{
    internal class MailManager
    {
        private string EmailAddress, Title, TextBody, SenderName, SenderSurname, ReceiverName, ReceiverSurname, MFCode;
        public void SendMail(string EmailAddress, string Title, string TextBody, string MFCode, string SenderName, string SenderSurname, string ReceiverName, string ReceiverSurname)
        {
            this.EmailAddress = EmailAddress;
            this.Title = Title;
            this.TextBody = TextBody;
            this.SenderName = SenderName;
            this.SenderSurname = SenderSurname;
            this.MFCode = MFCode;
            this.ReceiverSurname = ReceiverSurname;
            this.ReceiverName = ReceiverName;
            var email = new MimeMessage();

            email.From.Add(new MailboxAddress(SenderName + " " + SenderSurname, "Administrator"));
            email.To.Add(new MailboxAddress(ReceiverName + " " + ReceiverSurname, EmailAddress));

            email.Subject = Title;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = TextBody + MFCode
            };
            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                try
                {
                    smtp.Connect("smtp.gmail.com", 587, false);
                    smtp.Authenticate("lucrarelicenta2023@gmail.com", "lujengmcgxyytdtd");
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
