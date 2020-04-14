using System;
using System.Collections;
using System.Collections.Generic;

class MainClass
{

    public static void Main(string[] args)
    {
        Dictionary<char, int> saver = new Dictionary<char, int>();
        List<int> numbers = new List<int>();
        string text = "solo";
        int lenght = text.Length;
        int result = factorial(lenght);

        for (int i = 0; i < lenght; i++)
        {

            if (saver.ContainsKey(text[i]))
            {
                char key = text[i];
                saver[key] = saver[key] + 1;
            }
            else
            {
                saver.Add(text[i], 1);
            }
        }

        foreach (var elem in saver)
        {
            numbers.Add(elem.Value);
        }

        for(int i=0; i<numbers.Count; i++)
            result = result / factorial(numbers[i]);
   
        Console.WriteLine(result);

    }
        static int factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial(number - 1);
        }


        
    
}