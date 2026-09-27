// --- UNDERSTANDING THE NULL VALUE CONCEPT & HISTORY ---

// Tony Hoare's "Billion-Dollar Mistake" (1965)
// The variable is declared, but it points to absolute NOTHINGNESS in RAM
string playerName = null;

// The compiler allows this, but reading it without an assignment triggers a crash
// Console.WriteLine(playerName);
