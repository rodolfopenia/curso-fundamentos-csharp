// Define an array with mixed email addresses
string[] emails = { "user1@empresa.com", "customer@gmail.com", "boss@empresa.com", "guest@yahoo.com" };

// The foreach loop scans every email string inside the collection safely
foreach (string email in emails)
{
    // The if statement filters using the EndsWith string method
    if (email.EndsWith("@empresa.com"))
    {
        // Print only the authorized corporate emails to screen
        Console.WriteLine("Access: " + email);
    }
}
