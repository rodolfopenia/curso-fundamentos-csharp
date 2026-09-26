// --- PROGRAM MAIN EXECUTION ---

// 1. Display the automated menu for the first time
ShowMenu();

Console.WriteLine("\nPress ENTER to simulate navigating a module...");
Console.ReadLine();

// 2. Refresh and redraw the menu instantly after the user action
ShowMenu();
Console.WriteLine("\nMenu refreshed automatically!");


// --- FUNCTIONS DECLARATION AREA ---

// Declaramos nuestro procedimiento modular reutilizable
static void ShowMenu()
{
    // Clear the previous console screen data
    Console.Clear();

    // Print the clean system UI layout
    Console.WriteLine("=================================");
    Console.WriteLine("       SYSTEM MAIN MENU          ");
    Console.WriteLine("=================================");
    Console.WriteLine("1. Dashboard | 2. Settings | 3. Exit");
}
