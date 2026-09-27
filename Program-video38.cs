// --- THE MILLION-DOLLAR MISTAKE IN ACTION ---

// 1. Variable is declared but points to absolute NOTHINGNESS in memory
string playerName = null;

// 2. Syntax is 100% correct, so the compiler approves this file perfectly.
// However, calling a method like ToUpper() on a null reference triggers a dynamic crash.
string upperName = playerName.ToUpper(); 

// This line will never be reached because the system aborts execution above
Console.WriteLine(upperName);
