// Current available bank balance
double accountBalance = 500.00;

// Read user input from terminal and convert it to double
double requestedAmount = Convert.ToDouble(Console.ReadLine());

// Evaluate if the user has enough money
if (requestedAmount <= accountBalance)
{
    // Print success message
    Console.WriteLine("Withdrawal approved");
}
else
{
    // Print error message
    Console.WriteLine("Insufficient funds");
}
