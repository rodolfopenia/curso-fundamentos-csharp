// --- MULTI-LEVEL APP BLINDAJE WITH CASCADING TRY-CATCH ---

bool isInvalid = true;

do
{
    try
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine()); // Can throw FormatException

        Console.WriteLine("Enter a divisor:");
        int divisor = int.Parse(Console.ReadLine());
        int mathResult = number / divisor; // Can throw DivideByZeroException

        string emptyText = null;
        int length = emptyText.Length; // Can throw NullReferenceException

        // If execution reaches here, everything was successful
        isInvalid = false;
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Please enter a valid numeric format.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Error: Division by zero is mathematically impossible.");
    }
    catch (NullReferenceException)
    {
        Console.WriteLine("Error: Attempted to operate on an empty reference (NULL).");
    }

} while (isInvalid);

Console.WriteLine("¡Formulario procesado con éxito!");
