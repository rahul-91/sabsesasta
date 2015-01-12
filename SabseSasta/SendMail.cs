using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace SabseSasta
{
    public class SendMail
    {
        public static void response(string email, string body)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("bookworldresponse@gmail.com", "bookWorld");
            msg.To.Add(new MailAddress(email));
            msg.Subject = "book World Response Mail";
            msg.Body = body;
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential("bookworldresponse@gmail.com", "p@$$w0rd123");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(msg);
        }
    }
}