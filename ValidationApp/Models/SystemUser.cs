using Microsoft.AspNetCore.Mvc;

namespace ValidationApp.Models
{
    [ModelMetadataType(typeof(SystemUserValidation))]
    public class SystemUser
    {
        //[Required(ErrorMessage = "Please enter Id num")]
        //[IdentificationNumberValidation(ErrorMessage = "Id is not valid")]
        public int IdentificationNumber { get; set; }

        //[Required(ErrorMessage = "Enter Name")]
        //[StringLength(10, ErrorMessage = "Please Enter Between 3 and 10 Chars", MinimumLength = 3)]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Please Enter Score")]
        //[Range(0, 100, ErrorMessage = "Please Enter Between 0 and 100")]
        public int Score { get; set; }

        //[Required(ErrorMessage = "Please Enter Email")]
        //[MailValidation(ErrorMessage = "Email address must contain @contoso.com")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Please Enter Password")]

        public string Password { get; set; }
        //[NotMapped]
        //[Required(ErrorMessage = "Please Enter Password")]
        //[Compare("Password", ErrorMessage = "Password and Password Confirmation must be same")]
        public string PasswordConfirmation { get; set; }
    }
}
