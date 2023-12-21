using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Text yazin:");
        string inputText = Console.ReadLine();

        char targetChar = 'A';  
        int count = 0;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (targetChar == inputText[i])
            {
                count++;
            }
        }

        Console.WriteLine("A herfi soz icerisinde" + count + "eded var");
    }
}










