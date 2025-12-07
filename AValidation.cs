using System;
using System.Linq;

public class Validation
{
    public string ValidateID(string fieldName)
    {
        while (true)
        {
            Console.Write($"Enter {fieldName} (Format: H123): ");
            string id = Console.ReadLine().Trim();

            if (id.Length < 2 || id[0] != 'H')
            {
                Console.WriteLine("ID must start with 'H' and contain digits after H.");
                continue;
            }

            string digits = id.Substring(1);
            if (!digits.All(char.IsDigit))
            {
                Console.WriteLine("Digits after 'H' must be numeric.");
                continue;
            }

            return id;
        }
    }

    public string ValidateString(string field)
    {
        while (true)
        {
            Console.Write($"Enter {field}: ");
            string val = Console.ReadLine().Trim();

            if (val.Any(char.IsDigit))
            {
                Console.WriteLine($"{field} cannot contain numbers.");
                continue;
            }

            return val;
        }
    }

    public string ValidateEmail()
    {
        while (true)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (email.Contains("@") && email.Contains("."))
                return email;

            Console.WriteLine("Invalid email.");
        }
    }

    public string ValidateMobile()
    {
        while (true)
        {
            Console.Write("Enter Mobile (10 digits): ");
            string mobile = Console.ReadLine();

            if (mobile.Length == 10 && mobile.All(char.IsDigit))
                return mobile;

            Console.WriteLine("Invalid mobile number.");
        }
    }
}
