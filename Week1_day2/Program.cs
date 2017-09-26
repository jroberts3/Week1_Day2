using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //What data types have we talked about so far? 
            //An int is a whole number (no decimals)
            //A string is a collection of characters

            char firstintial = 'D';
            //Character or chars are single letters or numbers or symbols

            bool isTired = true;
            //Boolean or bool is true or false 

            //Other number data types
            float number = 2.164403304907294849383961032f;
            decimal partialNum = 2.164403304907294849383961032m;
            double someNumber = 2.164403304907294849383961032d;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);


            //Now, let's talk about operators!
            //ARITMETIC OPERATORS
            // + adds two operands
            // - Subtracts the second operand from the first
            // * Multiplies both operands 
            // / Divides first operand by second operand
            // % Modulus - divides and checks remainder
            // ++ Increments operator by one and is used for ints
            // -- Decrements decrease value by one
            // RELATIONAL OPERATORS
            // == Checks if the values of two operands are equal and if they are, returns bool true
            // != Checks if values of two operands are equal or not, and if values are NOT equal, returns bool true.

            int jarrydAge = 29;
            int danielAge = 32;
            Console.WriteLine(jarrydAge == danielAge);

            /*
             *  > Checks if the value of the left operand is greater than the value of the right operand, and if yes then condition is true
             *   < Checks if the value of the left operand is lelss than the value of the right operand, and if yes then condition is true
             *   >= Checks if the value of left operand is greater than of equal to the value of the right operand, and if yes then condition becomes true.
             *   <= Checks if the value of the left operand is less than or equal to the value of the right operand and if yes then condition becomes true.
             *   
             */

            //LOGICAL OPERATORS
            /*
             * && we call AND operator. If both the operands are non zero then condition becomes true.
             * || we call OR operator. If any two operands is non zero then condition becomes true. 
             * 
             * ! we call NOT operator. This is used with to reverse the logical state of the operand. 
             * If a condition is true then logical NOT operator will make false 
             * / 
         




               
        }
    }
}
