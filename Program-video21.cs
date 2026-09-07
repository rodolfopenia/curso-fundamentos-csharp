// Ask the user for the countdown starting point
Console.WriteLine("Enter countdown start seconds:");
int startSeconds = int.Parse(Console.ReadLine());

// The for loop decreases i by 1 until it hits zero
for (int i = startSeconds; i >= 0; i--)
{
    // Print the remaining seconds to screen
    Console.WriteLine("Time remaining: " + i);
}

// Loop terminates safely below zero
Console.WriteLine("¡BOOM! 💥");
