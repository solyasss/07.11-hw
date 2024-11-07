using System;
using System.Text.RegularExpressions;

namespace _07._11_hw;

class Program
{
    static bool check_name(string input)
    {
        string pattern = @"^[A-Z][a-z]+ [A-Z]\.([A-Z]\.)?$";
        Regex regex = new Regex(pattern);
        return regex.Match(input).Length > 0;
    }

    static bool check_email(string input)
    {
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{2,15}@[A-Za-z]+\.(?:[A-Za-z]{2,3})(?:\.[A-Za-z]{2,3})?$";
        Regex regex = new Regex(pattern);
        return regex.Match(input).Length > 0;
    }

    static bool check_date(string input)
    {
        string pattern = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-\d{4}$";
        Regex regex = new Regex(pattern);
        return regex.Match(input).Length > 0;
    }

    static void Main()
    {
        string input_name;
        do
        {
            Console.WriteLine("Enter last name and initials:");
            input_name = Console.ReadLine();
            if (check_name(input_name))
                Console.WriteLine("Correct input");
            else
                Console.WriteLine("Invalid input. Please try again.");
        } while (!check_name(input_name));

        string input_email;
        do
        {
            Console.WriteLine("Enter email:");
            input_email = Console.ReadLine();
            if (check_email(input_email))
                Console.WriteLine("Correct email");
            else
                Console.WriteLine("Invalid input. Please try again.");
        } while (!check_email(input_email));

        string input_date;
        do
        {
            Console.WriteLine("Enter a date in the format d-m-y:");
            input_date = Console.ReadLine();
            if (check_date(input_date))
                Console.WriteLine("Correct date");
            else
                Console.WriteLine("Invalid input. Please try again.");
        } while (!check_date(input_date));
    }
}