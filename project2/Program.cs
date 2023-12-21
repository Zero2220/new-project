using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Soz yaz:");
        string inputText = Console.ReadLine();

        char letterCheck = 'A';
        bool found = false;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == letterCheck)
            {
                found = true;
                break; 
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
