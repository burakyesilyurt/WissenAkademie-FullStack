using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace PassDataViewAndControls.Controllers
{
    public class MailController : Controller
    {
        private readonly ILogger<MailController> logger;

        public MailController(ILogger<MailController> _logger)
        {
            logger = _logger;
        }
        public IActionResult Index()
        {
            logger.LogInformation("Mail Form Loading", typeof(MailController));
            return View();
        }
        [HttpPost]
        public IActionResult Index(string txtEmail, string txtSubject, string txtMessage)
        {
            string msg = string.Empty;
            //SendGrid Mail API
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("info@contoso.com", "Contoso Inc.");
                message.To.Add(txtEmail);
                message.Subject = txtSubject;
                message.IsBodyHtml = true;
                message.Body = txtMessage;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("user", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                msg = "Mail successfully sent";
                ViewBag.Result = msg;
                logger.LogInformation(msg);
            }
            catch (Exception ex)
            {
                msg = "Hata: " + ex.Message;
                ViewBag.Result = msg;
                logger.LogWarning(msg);
            }
            return View();
        }
    }
}
