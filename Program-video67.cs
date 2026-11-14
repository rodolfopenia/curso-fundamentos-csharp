// --- MAIN PROGRAM (VIDEO 67: VALUE VS REFERENCE) ---

// 1. Value type: the value itself is copied
int a = 5;
int b = a;
b = 9;
Console.WriteLine("a = " + a + ", b = " + b);

// 2. Reference type: only the address is copied
int[] x = { 1, 2, 3 };
int[] y = x;
y[0] = 99;
Console.WriteLine("x[0] = " + x[0] + ", y[0] = " + y[0]);

// 3. The same happens when you call a function
int n = 10;
AddOne(n);
Console.WriteLine("n = " + n);

int[] nums = { 10, 20 };
AddOneToFirst(nums);
Console.WriteLine("nums[0] = " + nums[0]);

// 4. A real copy is a new array
int[] copy = x.ToArray();
copy[1] = 0;
Console.WriteLine("x[1] = " + x[1] + ", copy[1] = " + copy[1]);


// --- FUNCTIONS DECLARATION AREA ---

// Receives a copy of the number
static void AddOne(int value)
{
    value++;
}

// Receives the address of the same array
static void AddOneToFirst(int[] list)
{
    list[0]++;
}
