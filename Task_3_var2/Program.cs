/*
Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
*/

Console.Clear();
Console.WriteLine("Введите номер дня недели от 1 до 7");

string? a = Console.ReadLine();

//используем оператор Switch вместо If

switch (Int32.Parse(a)) {
    case 1:
        Console.WriteLine("Введенное число не выходной день");
        break;
    case 2:
        Console.WriteLine("Введенное число не выходной день");
        break;
    case 3:
        Console.WriteLine("Введенное число не выходной день");
        break;
    case 4:
        Console.WriteLine("Введенное число не выходной день");
        break;
    case 5:
        Console.WriteLine("Введенное число не выходной день");
        break;
    case 6:
        Console.WriteLine("Введенное число - выходной день");
        break;
    case 7:
        Console.WriteLine("Введенное число - выходной день");
        break;
    default:
        Console.WriteLine("Введенное число не является днем недели");
        break;
}
