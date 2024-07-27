using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Calculate class to use its methods
        Calculate calculate = new Calculate();
        // Display the program's motto at the start of the program
        DisplayMotto();
        // Start an infinite loop to keep the program running until the user decides to exit
        while (true)
        {
            // Display the menu options to the user
            DisplayMenu();
            // Read the user's menu choice
            string choice = Console.ReadLine();
            // Check if the user wants to calculate the revenue
            if (choice == "1")
            {
                // Prompt the user to enter the number of contestants from the previous year
                Console.Write("Enter the number of contestants from the previous year: ");
                int previousYearContestants = int.Parse(Console.ReadLine());
                // Prompt the user to enter the number of contestants for the current year
                Console.Write("Enter the number of contestants for the current year: ");
                int currentYearContestants = int.Parse(Console.ReadLine());
                // Calculate the revenue based on the number of contestants
                calculate.CalculateRevenue(previousYearContestants, currentYearContestants);
                // Display the program's motto again
                DisplayMotto();
            }
            // Check if the user wants to exit the program
            else if (choice == "2")
            {
                // Display a thank you message and exit the loop
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                break;
            }
            // Handle invalid menu choices
            else
            {
                // Inform the user of an invalid choice and prompt them to select again
                Console.WriteLine("Invalid choice, please select again.");
            }
        }
    }
     // Method to display the program's motto
    static void DisplayMotto()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("* The stars shine in Greenville. *");
        Console.WriteLine("*********************************");
    }
    // Method to display the menu options
    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }
}
// 2024/7/5_Sen_Shoikot_Project 0-1: [Greenville County Fair] GreenvilleRevenue v0.1