using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ABB_BF.BLL.Services
{
    public class ModelService : IModelsService
    {
        public bool IsNumberValid(string number)
        {
            string patternPhone = @"((8|\+7?)[\- ]?)?(\(?\d{3}\)?[\- ]?)?([\d\- ]{7,10})";
            return Regex.IsMatch(number, patternPhone);
        }

        public bool IsEmailValid(string email)
        {
            string patternEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patternEmail);
        }

        public string FixPhoneNumber(string number)
        {
            StringBuilder sb = new(number);

            if (sb.ToString().StartsWith("+7"))
            {
                sb.Replace("+7", "8");
            }

            foreach (char symbol in number)
            {
                sb.Replace("(", null);
                sb.Replace("-", null);
                sb.Replace(")", null);
            }

            return sb.ToString();
        }
    }
}
 