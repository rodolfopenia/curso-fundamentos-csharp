// Display the actions menu to the player
Console.WriteLine("Commands: ATTACK | DEFEND");

// Read user action and convert it completely to uppercase
string command = Console.ReadLine().ToUpper();

// Route execution based on string command
switch (command)
{
    case "ATTACK":
        // Execute attack animation
        Console.WriteLine("Character attacks! ⚔️");
        break;

    case "DEFEND":
        // Execute shield animation
        Console.WriteLine("Character defends! 🛡️");
        break;

    default:
        // Safeguard against untracked movements
        Console.WriteLine("Error: Unknown command");
        break;
}
