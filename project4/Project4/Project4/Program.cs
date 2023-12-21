using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("ededi daxil et");


        string nums = Console.ReadLine();

        int numbers = Convert.ToInt32(nums);


        
        

            if (numbers > 0 && numbers % 2 == 0)
            {

                numbers *= numbers;

                
                Console.WriteLine(numbers);


            }

            else Console.WriteLine("Yeniden daxil edin");








        

























    }
}
