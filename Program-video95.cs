// --- MAIN PROGRAM (VIDEO 95: THE DESK CHECK) ---

int[] numbers = { 4, 7, 2, 9 };
int sum = 0;
int max = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
    if (numbers[i] > max) max = numbers[i];
}

Console.WriteLine("Sum: " + sum + ", Max: " + max);
