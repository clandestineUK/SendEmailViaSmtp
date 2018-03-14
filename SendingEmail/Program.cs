using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SendingEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            //to and from email address
            MailMessage mail = new MailMessage("elliot.morris@wsg.co.uk", "elliotmorris115@gmail.com");
            SmtpClient client = new SmtpClient();
            //These are the details for the smtp
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            //Specify your smtp host name and port
            client.Port = 25;
            client.Host = "192.20.20.11";
            //This creates the subject and body of the email
            mail.Subject = "this is a test email";
            mail.Body = "test body";
            //This adds an attachment to the email
            Attachment csv;
            csv = new Attachment(@"C:\Users\morrise\Desktop\testfile.csv");
            mail.Attachments.Add(csv);

            client.Send(mail);
            Console.WriteLine("Email sent via " + client.Host);

        }
    }
}
