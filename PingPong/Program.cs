using System;
using System.Collections.Generic;

namespace PingPong.Models
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");

            string num = Console.ReadLine();
            int numInt = int.Parse(num);

            // MyPingPong.PrintPingPongSequence(numInt);

            // List<int> numList = new List<int>(){numInt};
            
            // static void PrintPingPongSequence()
            // {
                for (int i = 1; i <= numInt; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine("Ping-Pong");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Ping");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Pong");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            // }

        }
    }
    
}