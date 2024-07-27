using System;

public class Calculate
{
    // Method to generate and return the display message with the motto and menu
    public string GetDisplayMessage()
    {
        // Strings that make up the motto and menu
        string w1 = "*********************************\n";
        string w2 = "* The stars shine in Greenville. *\n";
        string w3 = "*********************************\n";
        string w4 = "Please Enter the following number below from the following menu:\n\n";
        string w5 = "1. CALCULATE Greenville Revenue Year-Over-Year\n";
        string w6 = "2. Exit\n";
        // Link and return the complete message
        return w1 + w2 + w3 + w4 + w5 + w6;
    }
    // Method to generate and return a sample message about the competition
    public string GetMessage()
    {
        // Strings that make up the sample message
        string s1 = "Last year's competition had 122 contestants, and this year's has 426 contestants\n";
        string s2 = "Revenue expected this year is $10,650\n";
        string s3 = "It is true that this year's competition is bigger than last year's.\n";
        // Concatenate and return the complete message
        return s1 + s2 + s3;
    }
    // Method to calculate and display the expected revenue based on the number of contestants
    public void CalculateRevenue(int previousYearContestants, int currentYearContestants, int ticketPrice = 25)
    {
        // Calculate the expected revenue
        int expectedRevenue = currentYearContestants * ticketPrice;
        // Display the number of contestants for both years
        Console.WriteLine($"Last year's competition had {previousYearContestants} contestants, " +
                          $"and this year's has {currentYearContestants} contestants.");
        // Display the expected revenue
        Console.WriteLine($"Revenue expected this year is ${expectedRevenue}");

        // Compare the number of contestants and display whether this year's competition is bigger
        if (currentYearContestants > previousYearContestants)
        {
            Console.WriteLine("It is true that this year's competition is bigger than last year's.");
        }
        else
        {
            Console.WriteLine("It is false that this year's competition is bigger than last year's.");
        }
    }
}
// 2024/7/5_Sen_Shoikot_Project 0-1: [Greenville County Fair] GreenvilleRevenue v0.1