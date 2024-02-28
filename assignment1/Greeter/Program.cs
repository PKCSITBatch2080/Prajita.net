
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your date of birth (YYYY-MM-DD):");
        DateTime dob;

        // Prompt user until a valid date is entered
        while (!DateTime.TryParse(Console.ReadLine(), out dob))
        {
            Console.WriteLine("Invalid date format. Please enter your date of birth in YYYY-MM-DD format:");
        }

        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Calculate age
        int ageYears = currentDate.Year - dob.Year;
        int ageMonths = currentDate.Month - dob.Month;
        int ageDays = currentDate.Day - dob.Day;

        // Adjust age if the current month and day are before the birth month and day
        if (ageMonths < 0 || (ageMonths == 0 && ageDays < 0))
        {
            ageYears--;
            ageMonths += 12;
        }

        // Display the age
        Console.WriteLine($"Your age is: {ageYears} years, {ageMonths} months, and {ageDays} days.");
    }
}

