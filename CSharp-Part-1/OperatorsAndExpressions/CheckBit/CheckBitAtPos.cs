﻿//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p(counting from 0, starting from the right) in given integer number n, has value of 1.

using System;
class CheckBitAtPos
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Choose bit position, counting from 0: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nAndMask = n & mask;

        Console.WriteLine(nAndMask >> p == 1);
    }
}