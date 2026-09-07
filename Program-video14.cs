// Display automated menu to user
Console.WriteLine("1. Sales | 2. Support | 3. Billing");

// Read user choice and convert to integer
int userOption = int.Parse(Console.ReadLine());

// Route the execution directly using switch
switch (userOption)
{
    case 1:
        // Execute sales module
        Console.WriteLine("Connecting to sales...");
        break;

    case 2:
        // Execute support module
        Console.WriteLine("Connecting to support...");
        break;

    case 3:
        // Execute billing module
        Console.WriteLine("Connecting to billing...");
        break;

    default:
        // Safeguard against invalid inputs
        Console.WriteLine("Error: Invalid option");
        break;
}
