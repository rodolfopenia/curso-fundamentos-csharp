// --- PROGRAM MAIN EXECUTION ---

// Test 1: Successful invocation with correct types and matching variable
double pesos = ConvertCurrency(100.0, 3.7);
Console.WriteLine(pesos);

// Test 2 (Error Simulation): Missing parameter - Compiler will block this
// double pesos = ConvertCurrency(100.0);

// Test 3 (Error Simulation): Wrong data type - Cannot convert string to double
// double pesos = ConvertCurrency("cien", 3.7);


// --- FUNCTIONS DECLARATION AREA ---

// The function expects exactly TWO double parameters and RETURNS a double
static double ConvertCurrency(double dollars, double exchangeRate)
{
    double totalCoins = dollars * exchangeRate;
    return totalCoins;
}
