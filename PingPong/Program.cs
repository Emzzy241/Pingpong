using System;
using System.Collections.Generic;

namespace PingPong.Models
{
    class Program
    {
        static void Main()
        {
           while (true)
           {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hello My Beautiful User, Welcome to the Dynasty's PING PONG Tournament");
                Console.WriteLine();
                Console.WriteLine("Please Enter a Number greater than 0");
                string num = Console.ReadLine();
                int numInt = int.Parse(num);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Game Starts!");


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
                    Console.WriteLine();
                    Console.WriteLine("Lets go Again");
           }


        }
    }
    
}