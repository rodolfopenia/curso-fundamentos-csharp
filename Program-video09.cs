// Fixed tip percentage - Constants in UPPERCASE
const double TIP_PERCENTAGE = 0.10;

// Restaurant bill amount - Variables in English
double totalBill = 100.00;

// Calculate tip and total using math operators
double tipAmount = totalBill * TIP_PERCENTAGE;
double finalAmount = totalBill + tipAmount;

// Print final result to screen
Console.WriteLine(finalAmount);
