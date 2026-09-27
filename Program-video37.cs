// --- ANATOMY OF SYSTEM EXCEPTIONS ---

// 1. Math Error: Division by zero triggers DivideByZeroException
int dividend = 10;
int divisor = 0;
// int mathResult = dividend / divisor; 


// 2. Memory Error: Accessing an invalid slot triggers IndexOutOfRangeException
int[] numbers = { 10, 20, 30 }; // Valid indices are 0, 1 and 2

// This index does not exist in memory, triggering a system crash at runtime
// Console.WriteLine(numbers[5]); 
