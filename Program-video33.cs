// --- PROGRAM MAIN EXECUTION (MAIN CLASS AREA) ---

// Invocación en ráfaga: El compilador elige la función según los argumentos
Sum(5, 10);

Sum(5, 10, 20);


// --- FUNCTIONS DECLARATION AREA (SAME FILE) ---

// Overload 1: Receives exactly TWO integers
static void Sum(int a, int b)
{
    int result = a + b;
    Console.WriteLine("Función de suma de dos números: " + result);
}

// Overload 2: Same name, but receives THREE integers
static void Sum(int a, int b, int c)
{
    int result = a + b + c;
    Console.WriteLine("Función de suma de tres números: " + result);
}
