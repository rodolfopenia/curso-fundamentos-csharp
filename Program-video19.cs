string userResponse;

// Prompt the user first, then validate the text string
do
{
    // Display choices menu clearly
    Console.WriteLine("Are you sure you want to exit? (SI/NO):");
    userResponse = Console.ReadLine().ToUpper();

} while (userResponse != "SI" && userResponse != "NO"); // Loop continues if input is neither SI nor NO

// Loop terminates safely with a valid choice
Console.WriteLine("Application closed successfully.");
