﻿/*
Задача 1: Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число
 и на выходе показывает вторую цифру этого числа.

*/

int Rand = new Random().Next(100, 999); // получаем произвольное трехзначное число

Console.WriteLine(Rand); // выводим значение на экран

Rand = Rand / 10; // "укоротим" число до двух цифр
Rand = Rand % 10; // получаем вторую цифру, нахождением остатка от деления на 10
Console.WriteLine("Вторая цифра числа: " + Rand); // показываем вторую цифру числа
