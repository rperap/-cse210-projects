using System;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World! brooo I am learning!!");

         
        Console.Write("What was your grade percentage? ");
        string UserInput = Console.ReadLine();

        int A = int.Parse(UserInput);
        
        


       if (A >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }
        else if (A >= 80 && A <= 90)
        {
            Console.WriteLine("Your grade equals to B");
        }

        else if (A >= 70 && A <= 80) 
        {
            Console.WriteLine("Your grade equals to C");
        }
        else if (A >= 60 && A <= 70) 
        {
            Console.WriteLine("Your grade equals to D");
        }
        else 
        {
            Console.WriteLine("Your grade equals to F");
        }
       

        //Console.WriteLine($"Your grade was {A}");
        if (A >= 70)
        {
            Console.WriteLine("Congratulations! you passed the class");
        }
        else if(A <=70 )
        {
            Console.WriteLine("We're sorry but you couldn't pass the class at this time, lets conquer it next year!");
        }
    }
}