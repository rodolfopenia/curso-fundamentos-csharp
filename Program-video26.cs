// 1. Initialize a 3x3 bidimensional string array for the game map
string[,] map = new string[3, 3];

// 2. Ask the user for the row and column coordinates
Console.WriteLine("Enter row coordinate (0-2):");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter column coordinate (0-2):");
int col = int.Parse(Console.ReadLine());

// 3. Assign the value 'X' directly into the matrix coordinates
map[row, col] = "X";

Console.WriteLine("\n--- UPDATED MAP ---");

// 4. Nested loops to print the full grid
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        // Print cell content (default to "." if empty, or "X")
        string cell = map[i, j] ?? ".";
        Console.Write(cell + " ");
    }
    Console.WriteLine(); // New line after each row
}
