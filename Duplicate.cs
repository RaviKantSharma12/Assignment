using System;

public class DuplicateCharacters  
{  
    public static void Main()  
    {   
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int[] count = new int[256]; 

                for (int i = 0; i < input.Length; i++)
        {
            count[(int)input[i]]++;
        }

                for (int i = 0; i < 256; i++)
        {
            if (count[i] > 1)
            {
                Console.WriteLine("{0}: {1}", (char)i, count[i]);
            }
        }
    }    
}