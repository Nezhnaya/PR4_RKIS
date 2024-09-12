using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_SendingEmail.UsersСlasses;

namespace WindowsFormsApp1.UsersClasses
{
    public class InfoGMail : InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body) : 
            base (emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("evmilenium@gmail.com", "Миленина, Парфенова");
            EmailPassword = "inxlrmkybyzspbvu";
            Port = 587;
        }
    }
}
