using System;

class Program
{
    static void Main(string[] args)
    {
        Calculate calculate = new Calculate();

        DisplayMotto();
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter the number of contestants from the previous year: ");
                int previousYearContestants = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of contestants for the current year: ");
                int currentYearContestants = int.Parse(Console.ReadLine());

                calculate.CalculateRevenue(previousYearContestants, currentYearContestants);
                DisplayMotto();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please select again.");
            }
        }
    }

    static void DisplayMotto()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("* The stars shine in Greenville. *");
        Console.WriteLine("*********************************");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }
}
// 2024/7/5_Sen_Shoikot_Project 0-1: [Greenville County Fair] GreenvilleRevenue v0.1