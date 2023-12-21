using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string inputText = Console.ReadLine();

        char letterCheck = 'A';
        bool found = false;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == letterCheck)
            {
                found = true;
                break; // Exit the loop if 'A' is found
            }
        }

        if (found)
        {
            Console.WriteLine("A herfi var");
        }
        else
        {
            Console.WriteLine("A herfi yoxdur");
        }
    }
}
