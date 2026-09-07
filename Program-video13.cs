// Read school score from terminal and convert to integer
int finalScore = int.Parse(Console.ReadLine());

// 1. Validation - Check if score is out of bounds (0 to 20)
if (finalScore < 0 || finalScore > 20)
{
    // Print out of range error message
    Console.WriteLine("Invalid score");
}
// 2. Cascade Evaluation for valid scores
else if (finalScore >= 16)
{
    // Outstanding score (16 to 20)
    Console.WriteLine("Grade: AD");
}
else if (finalScore >= 13)
{
    // Good score (13 to 15)
    Console.WriteLine("Grade: A");
}
else if (finalScore >= 11)
{
    // Regular score (11 to 12)
    Console.WriteLine("Grade: B");
}
else
{
    // Needs improvement (0 to 10)
    Console.WriteLine("Grade: C");
}
