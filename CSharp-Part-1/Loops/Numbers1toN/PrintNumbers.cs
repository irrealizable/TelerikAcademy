﻿using System;
class PrintNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i != n)
            {
                Console.Write(i + " ");
            }
            else
            {
                Console.Write(i);
            }
        }
    }
}