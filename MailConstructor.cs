using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DZ4.Program;

namespace DZ4
{
     class MailBuilder:IMailBuilder
    {
        Mail mail;
        public MailBuilder()
        {
            mail = new Mail();
        }
        public IMailBuilder AddRecipient(string recipient)
        {
            mail.Recipient = recipient;
            return this;
        }
        public IMailBuilder AddContent(string content)
        {
            mail.Content = content;
            return this;
        }
        public IMailBuilder AddAttachments(string attachments)
        {
            mail.Attachments = attachments;
            return this;
        }
        public IMailBuilder AddSubject(string subject)
        {
            mail.Subject = subject;
            return this;
        }
        public Mail Build()
        {
            return mail;
        }
    }
}
