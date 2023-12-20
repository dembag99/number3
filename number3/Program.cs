using System;
using System.Collections.Generic;
public class program
{

    public static void Main()
    {
        var list = new List<int>();

        while (list.Count < 5)
        {
            Console.WriteLine("Type 5 unique numbers:");
            var input = Convert.ToInt32(Console.ReadLine());

            if (list.Contains(input))
                Console.WriteLine("Error! Number already in list!");
            else
                list.Add(input);
        }

        list.Sort();
        foreach (var number in list)
        {
            Console.Write("{0} ", number);
        }
    }
}
