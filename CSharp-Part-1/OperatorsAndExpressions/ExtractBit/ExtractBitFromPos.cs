﻿//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;
class ExtractBitFromPos
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Choose bit position, counting from 0: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int maskAndNumber = mask & n;
        int bit = maskAndNumber >> p;

        Console.WriteLine(bit);
    }
}