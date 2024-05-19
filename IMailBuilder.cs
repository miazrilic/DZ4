using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
     interface IMailBuilder {


        public IMailBuilder AddSubject(string subject);
        public IMailBuilder AddContent(string content);
        public IMailBuilder AddRecipient(string recipient);
        public IMailBuilder AddAttachments(string attachments);
        public Mail Build();
    }
}
