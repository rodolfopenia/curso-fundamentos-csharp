// --- MAIN PROGRAM (VIDEO 90: N-QUEENS, THE LOGIC) ---

int n = 4;
int[] queens = new int[n];    // queens[row] = its column
if (Place(queens, 0, n))
{
    Console.WriteLine("Solution: " + string.Join(", ", queens));
}


// --- FUNCTIONS DECLARATION AREA ---

// One queen per row: try each column, go back on a dead end
static bool Place(int[] queens, int row, int n)
{
    if (row == n) return true;
    string pad = new string(' ', row * 2);
    for (int col = 0; col < n; col++)
    {
        if (IsSafe(queens, row, col))
        {
            queens[row] = col;
            Console.WriteLine(pad + "row " + row + " -> col " + col);
            if (Place(queens, row + 1, n)) return true;
        }
    }
    Console.WriteLine(pad + "row " + row + ": dead end, back");
    return false;
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
