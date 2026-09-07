// Secret password defined in system
string securePassword = "admin123";
int attempts = 0;

// Repeat execution while attempts are under the limit
while (attempts < 3)
{
    Console.WriteLine("Enter password:");
    string userInput = Console.ReadLine();

    if (userInput == securePassword)
    {
        Console.WriteLine("Access granted! ✅");
        break; // Stop the loop immediately on success
    }
    
    // Increment counter to avoid infinite loop
    attempts++;
    Console.WriteLine("Wrong password");
}

// Check if loop ended because the user failed all attempts
if (attempts == 3)
{
    Console.WriteLine("SYSTEM LOCKED 🚨");
}
