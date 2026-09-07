// Ask the user for the countdown duration
Console.WriteLine("Enter launch countdown seconds:");
int maxSeconds = int.Parse(Console.ReadLine());

// The for loop condenses initialization, condition, and increment in one line
for (int i = 1; i <= maxSeconds; i++)
{
    // Print each second of the count to screen
    Console.WriteLine("Second " + i);
}

// Loop terminates safely when i exceeds maxSeconds
Console.WriteLine("¡LIFT OFF! 🚀");
