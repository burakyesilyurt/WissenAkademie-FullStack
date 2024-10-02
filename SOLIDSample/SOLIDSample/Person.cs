using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public void SendEmailPasswordResetLink(string userName)
        {
            //    //TODO : Find User from UserName
            //    int UserID = context.Users.GetUserWithUserName(userName);
            //    string passwordResetLink = CreateLink(UserID);
            //    string htmlContent = CreateMailTemplate(path, passwordResetLink);
            //    SendMail(htmlContent);

            EmailService emailService = new EmailService();
            emailService.SendMail(new Person() { PersonID = 1, Email = "john.doe@contoso.com" });
        }

        public void SendSms(Person person)
        {

        }

        public void SendNotification(Person person)
        {

        }

    }
}
