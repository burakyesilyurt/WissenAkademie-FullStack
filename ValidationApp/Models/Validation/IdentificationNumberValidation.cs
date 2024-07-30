using System.ComponentModel.DataAnnotations;

namespace ValidationApp.Models.Validation
{
    public class IdentificationNumberValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value != null) return false;
            string id = value.ToString();

            if (id.Length != 11) return false;

            if (id[0] == '0') return false;

            for (int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i]))
                {
                    return false;
                }
            }

            //int[] IdNum = new int[11];
            //for (int i = 0; i < 11; i++)
            //{
            //    IdNum[i] = int.Parse(id[i].ToString());
            //}

            //int tenDigit = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    tenDigit += IdNum[i];
            //}

            //if (tenDigit != IdNum[10])
            //{
            //    return false;
            //}

            return true;

            //return base.IsValid(value);
        }
    }
}
