int userAge;

// Execute the code block first, then evaluate the condition
do
{
    // Ask for input on each iteration
    Console.WriteLine("Enter your age:");
    userAge = int.Parse(Console.ReadLine());

} while (userAge <= 0); // Keep looping if age is invalid

// Loop terminates safely with a valid age
Console.WriteLine("Age saved successfully! ");
