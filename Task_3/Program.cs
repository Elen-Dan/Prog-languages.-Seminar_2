/*
Задача 3: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/
Console.Clear();
Console.WriteLine("Введите номер дня недели от 1 до 7");

string? a = Console.ReadLine();

if (Int32.Parse(a) <= 0 | Int32.Parse(a) > 7) {
    Console.WriteLine("Введенное число не является днем недели");
}
else if (Int32.Parse(a) >= 1 & Int32.Parse(a) <= 5) {
        Console.WriteLine("Введенный день недели не является выходным");
    }
else 
    {
        Console.WriteLine("Введенный день недели - выходной день");
    }    