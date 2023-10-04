using System;
//программа для суммирования двух случайно генерируемых чисел
int numberA = new Random().Next(1, 10); //генерируется случайное целое число в диапазоне от 1 до 9 включительно
int numberB = new Random().Next(1, 10);
Console.WriteLine("Первое число: " + numberA);
Console.WriteLine("Второе число: " + numberB);
int result = numberA + numberB;
Console.WriteLine("Сумма двух случайно генерируемых чисел равна: " + result);