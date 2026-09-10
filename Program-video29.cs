// --- PROGRAM MAIN EXECUTION ---

// Invocamos el proceso tres veces de forma consecutiva, limpia y rápida
ShowWelcome();
ShowWelcome();
ShowWelcome();

Console.WriteLine("Main software steps completed.");


// --- FUNCTIONS DECLARATION AREA ---

// Declaramos nuestro procedimiento reutilizable abajo
static void ShowWelcome()
{
    // Un procedimiento void ejecuta acciones pero NO retorna datos
    Console.WriteLine("=================================");
    Console.WriteLine("    WELCOME TO MY SOFTWARE     ");
    Console.WriteLine("=================================");
}
