﻿using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minute = 0; minute <= 59; minute++)
                {
                    Console.WriteLine($"{hour}:{minute}");
                }
            }
        }
    }
}
