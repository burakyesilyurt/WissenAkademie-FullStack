using System.ComponentModel.DataAnnotations;

namespace ValidationApp.Models.Validation
{
    public class MailValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string data = string.Empty;
            if (value == null) return false;
            data = value.ToString();
            if (data.Where(x => x == ' ').ToList().Count() > 0)
                return false;

            if (data.Split('@').Count() > 1) return false;

            if (data.EndsWith("@contoso.com"))
                return true;

            return false;


            //return base.IsValid(value);
        }
    }
}
