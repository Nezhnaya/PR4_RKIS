using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_SendingEmail.UsersСlasses;

namespace WindowsFormsApp1.UsersClasses
{
    public class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body) :
            base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("evmilenium@mail.ru", "Миленина, Парфенова");
            EmailPassword = "LVe53q7mjGavcQ6skn7q";
            Port = -1;
        }
    }
}
