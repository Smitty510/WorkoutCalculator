class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Write("Enter your max or type 'exit' to quit->");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "exit")
            {
                exit = true;
            }
            else
            {




                double value;

                if (double.TryParse(userInput, out value))
                {
                    double tenPercent = value * 0.1;
                    double twentyPercent = value * 0.2;
                    double thirtyPercent = value * 0.3;
                    double fortyPercent = value * 0.4;
                    double fiftyPercent = value * 0.5;
                    double sixtyPercent = value * 0.6;
                    double seventyPercent = value * 0.7;
                    double eightyPercent = value * 0.8;
                    double ninetyPercent = value * 0.9;

                    double roundedTenPercent = RoundToNearest5(tenPercent);
                    double roundedTwentyPercent = RoundToNearest5(twentyPercent);
                    double roundedThirtyPercent = RoundToNearest5(thirtyPercent);
                    double roundedFortyPercent = RoundToNearest5(fortyPercent);
                    double roundedFiftyPercent = RoundToNearest5(fiftyPercent);
                    double roundedSixtyPercent = RoundToNearest5(sixtyPercent);
                    double roundedSeventyPercent = RoundToNearest5(seventyPercent);
                    double roundedEightyPercent = RoundToNearest5(eightyPercent);
                    double roundedNinetyPercent = RoundToNearest5(ninetyPercent);

                    Console.WriteLine($"10% of {value} = {roundedTenPercent}");
                    Console.WriteLine($"20% of {value} = {roundedTwentyPercent}");
                    Console.WriteLine($"30% of {value} = {roundedThirtyPercent}");
                    Console.WriteLine($"40% of {value} = {roundedFortyPercent}");
                    Console.WriteLine($"50% of {value} = {roundedFiftyPercent}");
                    Console.WriteLine($"60% of {value} = {roundedSixtyPercent}");
                    Console.WriteLine($"70% of {value} = {roundedSeventyPercent}");
                    Console.WriteLine($"80% of {value} = {roundedEightyPercent}");
                    Console.WriteLine($"90% of {value} = {roundedNinetyPercent}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric value.");
                }


            }

            static double RoundToNearest5(double number)
            {
                return Math.Round(number / 5.0) * 5.0;
            }
        }
    }
}


