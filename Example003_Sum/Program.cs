﻿// Написать программу сложения двух чисел.
// int numberA = 3;
// int numberB = 5;
// System.Console.WriteLine(numberA + numberB);

// int numberA = 31;
// int numberB = 5;
// int result = numberA + numberB;
// System.Console.WriteLine(result);


int numberA = new Random().Next(1, 10); // 0 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
System.Console.WriteLine(result);