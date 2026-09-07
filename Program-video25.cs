// 1. Initialize an empty double array for 5 days of the week
double[] sales = new double[5];

// 2. Loop to populate the array dynamically with user inputs
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter sales amount:");
    sales[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("\n--- WEEKLY SALES REPORT ---");

// 3. Loop to traverse and print the array elements using indices
for (int i = 0; i < 5; i++)
{
    // print the human day (i + 1) and the exact data stored in sales[i]
    Console.WriteLine("Day " + (i + 1) + ": $" + sales[i]);
}
