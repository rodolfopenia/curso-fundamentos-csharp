// --- PROGRAM MAIN EXECUTION ---

Console.WriteLine("Enter number of disks:");
int diskCount = int.Parse(Console.ReadLine());

Console.WriteLine("\n--- STARTING MOVEMENT STEPS ---");

// Invoking the generic function using 4 disks for our video simulation
SolveHanoi(diskCount, "Origen", "Auxiliar", "Destino");


// --- FUNCTIONS DECLARATION AREA (RECURSIVE ENGINE) ---

// Generic function capable of solving Hanoi for any number of disks 'n'
static void SolveHanoi(int n, string source, string auxiliary, string destination)
{
    // 1. Caso Base: The ultimate stop condition that clears the RAM stack
    if (n == 1)
    {
        Console.WriteLine("Move disk 1 from " + source + " to " + destination);
        return; // Break the recursive chain
    }

    // 2. Caso Recursivo - Step A: Move n-1 disks to auxiliary pole swapping destination role
    SolveHanoi(n - 1, source, destination, auxiliary);

    // 3. Caso Recursivo - Step B: Move the bottom heavy disk to final destination
    Console.WriteLine("Move disk " + n + " from " + source + " to " + destination);

    // 4. Caso Recursivo - Step C: Move the n-1 disks from auxiliary to final destination swapping source role
    SolveHanoi(n - 1, auxiliary, source, destination);
}
