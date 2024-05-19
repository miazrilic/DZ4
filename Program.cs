using static DZ4.Program;

namespace DZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            IMailBuilder mailBuilder = new MailBuilder();
            SMTP smtp = new SMTP(mailBuilder);


            smtp.SendNoReplyMail();
            smtp.SendMail();





        }
    }
}