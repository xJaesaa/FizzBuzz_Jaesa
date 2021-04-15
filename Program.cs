﻿using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++){ //as long as i is greater than or equal to 100 it will continue until it does
                if(i % 3 == 0 && i % 5 == 0){ //
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else{
                    Console.WriteLine(i);
                }
            }
        }
    }
}
