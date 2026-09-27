// --- UNDERSTANDING RUNTIME EXCEPTIONS ---

// Syntax is 100% correct - Compiler will approve this line perfectly
int dividend = 10;
int divisor = 0; // Imagine this comes dynamic from a user input

// Execution Error: Division by zero is mathematically impossible
// This will trigger a dynamic 'DivideByZeroException' at runtime
int result = dividend / divisor; 
