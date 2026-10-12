// --- PROGRAM MAIN EXECUTION (VIDEO 50 MILESTONE) ---

// Instanciamos el arreglo de tamaño fijo de forma estricta
int[] products = new int; 

// 1. Loop to populate the product codes interactively from terminal
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Enter product code:");
    products[i] = int.Parse(Console.ReadLine());
}

// 2. Invoke Merge Sort passing boundaries from index 0 to 3
MergeSort(products, 0, products.Length - 1);

Console.WriteLine("\n--- SORTED PRODUCTS REPORT ---");

// 3. Print sorted values cleanly to screen
for (int i = 0; i < products.Length; i++)
{
    Console.Write(products[i] + " ");
}
Console.WriteLine();


// --- FUNCTIONS DECLARATION AREA (ALGORITHMS) ---

static void MergeSort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int mid = left + (right - left) / 2;

        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);

        Merge(arr, left, mid, right);
    }
}

static void Merge(int[] arr, int left, int mid, int right)
{
    int n1 = mid - left + 1; 
    int n2 = right - mid; 

    int[] leftTemp = new int[n1];
    int[] rightTemp = new int[n2];

    for (int idx1 = 0; idx1 < n1; idx1++) leftTemp[idx1] = arr[left + idx1];
    for (int idx2 = 0; idx2 < n2; idx2++) rightTemp[idx2] = arr[mid + 1 + idx2];

    int i = 0, j = 0;
    int k = left; 

    // BUCLE 1: Compare initial elements and merge them stably back to the array
    while (i < n1 && j < n2)
    {
        if (leftTemp[i] <= rightTemp[j])
        {
            arr[k] = leftTemp[i];
            i++;
        }
        else
        {
            arr[k] = rightTemp[j];
            j++;
        }
        k++;
    }

    // BUCLE 2: Copy remaining elements of leftTemp if any (Left sweep)
    while (i < n1)
    {
        arr[k] = leftTemp[i];
        i++;
        k++;
    }

    // BUCLE 3: Copy remaining elements of rightTemp if any (Right sweep)
    while (j < n2)
    {
        arr[k] = rightTemp[j];
        j++;
        k++;
    }
}
