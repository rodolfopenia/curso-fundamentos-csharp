// User credentials verification states
bool correctUser = true;
bool correctPass = true;

// Evaluate login access using the logical AND operator (&&)
bool canLogin = correctUser && correctPass;

// Print the final authentication result
Console.WriteLine(canLogin);
