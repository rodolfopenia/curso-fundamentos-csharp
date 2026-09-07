// 1. Initialize a 3x3 movie theater seating matrix
string[,] theater = new string[3,3];

// 2. Populate the matrix with empty slots "."
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        theater[i, j] = ".";
    }
}

// 3. Print current seating map (Initial state)
Console.WriteLine("Current Seats:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(theater[i, j] + " ");
    }
    Console.WriteLine();
}

// 4. Read interactive user selection
Console.WriteLine("\nEnter row (0-2):");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter column (0-2):");
int col = int.Parse(Console.ReadLine());

// 5. Validate and update selection
if (theater[row, col] == ".")
{
    theater[row, col] = "X"; // Reserve seat
    Console.WriteLine("Reservation successful!");
}
else
{
    Console.WriteLine("Seat already taken!");
}

// 6. Print updated seating map (Final state)
Console.WriteLine("\nUpdated Seats:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(theater[i, j] + " ");
    }
    Console.WriteLine();
}
