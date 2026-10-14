// --- PROGRAM MAIN EXECUTION (VIDEO 43: EL MOTOR RECURSIVO) ---

// 1. Ask the user how many disks we will play with
Console.WriteLine("Enter number of disks:");
int diskCount = int.Parse(Console.ReadLine());

Console.WriteLine("\n--- STARTING MOVEMENT STEPS ---");

// 2. Invoke the recursive engine: Left = source, Middle = auxiliary, Right = destination
SolveHanoi(diskCount, "Left", "Middle", "Right");


// --- FUNCTIONS DECLARATION AREA (RECURSIVE ENGINE) ---

// Generic function capable of solving Hanoi for any number of disks 'n'
static void SolveHanoi(int n, string source, string auxiliary, string destination)
{
    // 1. Base case: only one disk left, move it directly and stop
    if (n == 1)
    {
        Console.WriteLine("Move disk 1 from " + source + " to " + destination);
        return; // Break the recursive chain
    }

    // 2. Step A: move n-1 disks out of the way (destination and auxiliary swap roles)
    SolveHanoi(n - 1, source, destination, auxiliary);

    // 3. Step B: move the biggest disk of this call to its destination
    Console.WriteLine("Move disk " + n + " from " + source + " to " + destination);

    // 4. Step C: bring the n-1 disks on top of it (source and auxiliary swap roles)
    SolveHanoi(n - 1, auxiliary, source, destination);
}
