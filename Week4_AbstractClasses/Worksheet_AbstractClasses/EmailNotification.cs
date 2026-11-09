using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Week4_AbstractClasses.Worksheet_AbstractClasses
{
    public class EmailNotification: Notification
    {
        string subject;
        public EmailNotification(string message, string _subject) : base(message)
        {
            subject = _subject;
        }

        public override void Send(Subscriber s)
        {
            //code won't work unless you activate lesssecureaps in your gmail

            MailMessage mm = new MailMessage("info@mcast.edu.mt", s.Email);
            mm.Subject = subject;
            mm.Body = Message;


            NetworkCredential credential = new NetworkCredential("username", "password");
            
            SmtpClient client = new SmtpClient("", 1);
            client.Credentials = credential;

            client.Send(mm);
        }
    }
}
