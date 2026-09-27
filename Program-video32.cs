// --- PROGRAM MAIN EXECUTION ---

// 1. Read the invoice subtotal amount from user
Console.WriteLine("Enter subtotal amount:");
double subTotal = double.Parse(Console.ReadLine());

// 2. Read the country destination string
Console.WriteLine("Enter country name:");
string countryInput = Console.ReadLine().ToUpper();

// 3. Invoke function with strict matching types and store returned tax
double finalTax = CalculateTax(subTotal, countryInput);

// 4. Print the final calculated tax result to screen
Console.WriteLine("Tax amount: $" + finalTax);


// --- FUNCTIONS DECLARATION AREA ---

// Function receives two input parameters and RETURNS a double
static double CalculateTax(double amount, string country)
{
    double taxAmount = 0.0;

    // Evaluate taxation rate based on country parameter
    if (country == "PERU")
    {
        taxAmount = amount * 0.18; // 18% IGV tax rate
    }
    else if (country == "MEXICO")
    {
        taxAmount = amount * 0.16; // 16% IVA tax rate
    }
    else
    {
        // Safeguard case for untracked regions
        taxAmount = 0.0; 
    }

    // Return the calculated data back to the caller
    return taxAmount;
}
