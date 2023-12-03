using System;
// using 

namespace PingPong.Models
{
    
    public class MyPingPong
    {
        public int Val1 { get; }

        // Constructor
        public MyPingPong(int myVal1)
        {
            Val1 = myVal1;
        }

        public object GameMethod()
        {
            object ifDivisibleByThree = "Ping";
            object ifDivisibleByFive = "Pong";
            // object ifDivisibleByBothFiveAndThree = "Ping-Pong";

            if(Val1 % 3 == 0)
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
        


    }
}