using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;
using System.Collections.Generic;
using System;

namespace PingPong.Tests
{
    [TestClass]
    public class MyPingPongTests
    {
        // First test: test will confirm MyPingPong objects of the PingPong type can be created successfully.
        [TestMethod]
        public void PingPongConstructor_CreatesInstanceOfPingPong_PingPong()
        {
            MyPingPong newPing = new MyPingPong(2);
            Assert.AreEqual(typeof(MyPingPong), newPing.GetType());


        }

        // 2nd Test: get functionality... User enters a value, YES. We want to make it a private field and get it
        [TestMethod]  
        public void GetValue_ReturnsValue_Int()
        {
            // Arrange 
            int num = 5;
            MyPingPong newPing = new MyPingPong(num);

            // Act
            int myNum = newPing.Val1;

            // Assert
            Assert.AreEqual(num, myNum);
        }

        // 3rd Test: set functionality... User enters a value, YES. We want to make it a private field and set the value
        [TestMethod]  
        public void SetValue_ReturnsValue_Void()
        {
            // Arrange 
            int num = 5;
            MyPingPong newPing = new MyPingPong(2);

            // Act
            num = newPing.Val1;

            // Assert
            Assert.AreEqual(2, num);
        }

        // 4th Test: ... GameMethod: THe method that determines the Game logic
        // First path: This path returns "Ping" if number is Divisible By Three
        // bn=
        [TestMethod]  
        public void GameMethodDivisibleByThree_ExecutesLogicForGame_Int()
        {
            // Arrange 
            int num = 3;
            object changeThree = "Ping";
            MyPingPong newPing = new MyPingPong(num);

            // Act
            object theReturn = newPing.GameMethod();

            // Assert
            Assert.AreEqual(theReturn, changeThree);
        }

        // 5th Test: ... GameMethod: THe method that determines the Game logic
        // Second path: This path returns "Pong" if number is Divisible By Five
        // bn=
        [TestMethod]  
        public void GameMethodDivisibleByFive_ExecutesLogicForGame_Int()
        {
            // Arrange 
            int num = 5;
            object changeThree = "Pong";
            MyPingPong newPing = new MyPingPong(num);

            // Act
            object theReturn = newPing.GameMethod();

            // Assert
            Assert.AreEqual(theReturn, changeThree);
        }

        // 6th Test: Third path, This path returns "Ping-Pong" if number is Divisible By Both Five And Three
        // bn=
        // [TestMethod]  
        // public void GameMethodDivisibleByBothFiveAndThree_ExecutesLogicForGame_Int()
        // {
        //     // Arrange 
        //     int num = 15;
        //     object changeThree = "Ping-Pong";
        //     MyPingPong newPing = new MyPingPong(num);

        //     // Act
        //     object theReturn = newPing.GameMethod();

        //     // Assert
        //     Assert.AreEqual(theReturn, changeThree);
        // }


    }

}