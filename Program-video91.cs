// --- MAIN PROGRAM (VIDEO 91: N-QUEENS IN C#) ---

int n = 4;
int[] queens = new int[n];    // queens[row] = its column
int total = Solve(queens, 0, n, true);
Console.WriteLine("Solutions for n = " + n + ": " + total);

for (int size = 5; size <= 8; size++)
{
    int count = Solve(new int[size], 0, size, false);
    Console.WriteLine("n = " + size + " -> " + count + " solutions");
}


// --- FUNCTIONS DECLARATION AREA ---

// Count every solution; print each board if asked
static int Solve(int[] queens, int row, int n, bool print)
{
    if (row == n)
    {
        if (print) PrintBoard(queens);
        return 1;
    }
    int count = 0;
    for (int col = 0; col < n; col++)
    {
        if (IsSafe(queens, row, col))
        {
            queens[row] = col;
            count += Solve(queens, row + 1, n, print);
        }
    }
    return count;
}

// One line per row: Q is the queen, . an empty square
static void PrintBoard(int[] queens)
{
    foreach (int col in queens)
    {
        string line = "";
        for (int c = 0; c < queens.Length; c++)
        {
            line += c == col ? "Q " : ". ";
        }
        Console.WriteLine(line);
    }
    Console.WriteLine();
}

// No earlier queen in the same column or on a diagonal
static bool IsSafe(int[] queens, int row, int col)
{
    for (int r = 0; r < row; r++)
    {
        int c = queens[r];
        if (c == col || Math.Abs(c - col) == row - r) return false;
    }
    return true;
}
