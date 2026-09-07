// Define a string array with the shopping cart products
string[] cart = { "phone", "laptop", "tablet", "watch" };

// Ask the user what product they want to search for
Console.WriteLine("Search product in cart:");
string searchInput = Console.ReadLine().ToLower();

// The foreach loop reads every string item inside the cart array safely
foreach (string item in cart)
{
    if (item == searchInput)
    {
        // Print success message if product matches user input
        Console.WriteLine("Product found: " + item.ToUpper() + "! ✅");
        break; // Stop scanning once found
    }
}
