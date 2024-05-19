using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
     class SMTP
    {

        IMailBuilder mailBuilder;
        public SMTP(IMailBuilder mailBuilder)
        {
            this.mailBuilder = mailBuilder;
        }

        public void SendNoReplyMail()
        {
            Mail mail= mailBuilder.AddSubject("No Reply").AddContent("Hello World").Build();
            //Sending logic here
            Console.WriteLine($"Subject: {mail.Subject}");
            Console.WriteLine($"Content: {mail.Content}");
        }
        public void SendMail()
        {
            Mail mail = mailBuilder.AddSubject("Nina Sucic").AddRecipient("Mia Zrilic").AddContent("Coffee date?").AddAttachments(".").Build();
            Console.WriteLine($"Subject: {mail.Subject}");
            Console.WriteLine($"Recipient: {mail.Recipient}");
            Console.WriteLine($"Content: {mail.Content}");
            Console.WriteLine($"Attachments: {mail.Attachments}");
        }
    }
}
