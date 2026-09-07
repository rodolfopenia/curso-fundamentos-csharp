// Ask the user for the file size in the terminal
Console.WriteLine("Enter file size in MB:");

// Read user input and convert to integer
int fileMb = int.Parse(Console.ReadLine());

// Loop runs in reverse until it reaches zero
while (fileMb > 0)
{
    // Print current state to screen
    Console.WriteLine("Remaining: " + fileMb + "MB");
    
    // Decrement counter by 1 to move backward
    fileMb--;
}

// Loop terminates safely at zero
Console.WriteLine("Download complete! 💾");
