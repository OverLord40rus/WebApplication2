using System.Text.RegularExpressions;

namespace WebApplication2.Validation
{
    public class NumberValidation
    {
        public bool IsValid (string phone)
        {
            Regex regex = new Regex(@"^(\+7|8){1}\s\d{3}\s\d{3}\-\d{2}\-\d{2}$");
            return regex.IsMatch(phone.ToString());

        }
    }
}
