using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] x = new string[5];
        
        Console.WriteLine ("Let's fill your inventory!");
        
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine ($"\nItem {i+1}:");
            x[i] = Console.ReadLine().ToLower();
        }
        
        char repeat = 's';
        
        do
        {
            Console.WriteLine ("Write a item what you want to search:");
            string search = Console.ReadLine().ToLower();
            bool found = false;
            
            for(int i = 0; i < 5; i++)
            {
                if(search == x[i])
                {
                    Console.WriteLine ($"Item found! {search.ToUpper()}.");
                    found = true;
                    break;
                }
            }
            if(found == false)
            {
                Console.WriteLine ($"Item not found!");
            }
            Console.WriteLine ($"Do you wish search another item? (S/N)");
            repeat = char.Parse(Console.ReadLine().ToLower());
        }
        while(repeat == 's');
        Console.WriteLine ($"\nGoodBye!");
    }
}