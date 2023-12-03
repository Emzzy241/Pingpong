using System;
using System.Collections.Generic;

namespace PingPong.Models
{
    
    public class MyPingPong
    {
        public int Val1 { get; set; }

        // private static List<MyPingPong> _pingpongInstances = new List<MyPingPong>() {};

        // Constructor
        public MyPingPong(int myVal1)
        {
            Val1 = myVal1;
            // _pingpongInstances.Add(this);
        }

        public object GameMethod()
        {
            List<object> myObj = new List<object>(){Val1};
            object ifDivisibleByThree = "Ping";
            object ifDivisibleByFive = "Pong";
            object ifDivisibleByBothFiveAndThree = "Ping-Pong";

            if (Val1 % 5 == 0 && Val1 % 3 == 0)
            {
                return ifDivisibleByBothFiveAndThree;
            }

            else if(Val1 % 3 == 0)
            {
                return ifDivisibleByThree;
            }

            else if (Val1 % 5 == 0)
            {
                return ifDivisibleByFive;
            }

            else{
                return Val1;
            }
        }
        // public object GameMethod()
        // {
        //     object ifDivisibleByThree = "Ping";
        //     object ifDivisibleByFive = "Pong";
        //     object ifDivisibleByBothFiveAndThree = "Ping-Pong";

        //     if (Val1 % 5 == 0 && Val1 % 3 == 0)
        //     {
        //         return ifDivisibleByBothFiveAndThree;
        //     }

        //     else if(Val1 % 3 == 0)
        //     {
        //         return ifDivisibleByThree;
        //     }

        //     else if (Val1 % 5 == 0)
        //     {
        //         return ifDivisibleByFive;
        //     }

        //     else{
        //         return Val1;
        //     }
        // }
        }

        // public object GameMethod()
        // {
        //     // List<object> result = new List<object>();
        //     // object ifDivisibleByThree = "Ping";
        //     // object ifDivisibleByFive = "Pong";
        //     // object ifDivisibleByBothFiveAndThree = "Ping-Pong";
        //     object myObj = Val1;

        //      for (int i = 1; i <= myObj; i++)
        //         {
        //             if ((i % 5 == 0) && (i % 3 == 0))
        //             {
        //                 // return ifDivisibleByBothFiveAndThree;
        //                 // result.Add(ifDivisibleByBothFiveAndThree);
        //                 result.Add("Ping-Pong");
        //             }
        //             else if ((i % 3 == 0))
        //             {
        //                 result.Add("Ping");
        //             }
        //             else if ((i % 5 == 0))
        //             {
        //                 result.Add("Pong");
        //                 // return ifDivisibleByFive;
        //                 // result.Add(ifDivisibleByFive);
        //             }
        //             else
        //             {
        //                 result.Add(i);
        //             }
        //         }
        //         return result;
        // }

        //  public void PrintPingPongSequence()
        //     {
        //         for (int i = 1; i <= Val1; i++)
        //         {
        //             if (i % 5 == 0 && i % 3 == 0)
        //             {
        //                 Console.WriteLine("Ping-Pong");
        //             }
        //             else if (i % 3 == 0)
        //             {
        //                 Console.WriteLine("Ping");
        //             }
        //             else if (i % 5 == 0)
        //             {
        //                 Console.WriteLine("Pong");
        //             }
        //             else
        //             {
        //                 Console.WriteLine(i);
        //             }
        //         }
        //     }

        // private static void GetAllNums()
        // {
            
        // }
        


    }