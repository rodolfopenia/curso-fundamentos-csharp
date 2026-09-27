// --- PROGRAM MAIN EXECUTION ---

// Run 1: Basic text message (void procedure)
SendMessage("Connected");

// Run 2: Message with numeric error status (void procedure)
SendMessage("Page not found", 404);

// Run 3: Message with receipt status (returns boolean)
bool receiptStatus = SendMessage("System Update", true);
Console.WriteLine("LOG: Message delivered. Receipt required: " + receiptStatus);

// Run 4: Message with digital signature (returns string)
string encryptedLog = SendMessage("Backup initiated", "Admin");
Console.WriteLine(encryptedLog);

// Blindaje Test (Error Simulation): 5 parameters will prevent compilation
// SendMessage("Data", 1, true, "Admin", "Extra");


// --- FUNCTIONS DECLARATION AREA (4-LEVEL OVERLOAD) ---

// Overload 1: Receives only one string (void)
static void SendMessage(string text)
{
    Console.WriteLine("NOTIFICATION: " + text);
}

// Overload 2: Same name, receives a string AND an integer (void)
static void SendMessage(string text, int statusCode)
{
    Console.WriteLine("CRITICAL ALERT: " + text + " (Code: " + statusCode + ")");
}

// Overload 3: Same name, receives a string AND a bool (RETURNS bool)
static bool SendMessage(string text, bool requiresReceipt)
{
    Console.WriteLine("RECEIPT PROCESS: " + text);
    return requiresReceipt;
}

// Overload 4: Same name, receives TWO strings (RETURNS string)
static string SendMessage(string text, string signerName)
{
    return "SECURE LOG: " + text + " | Signed by: " + signerName;
}
