/*
Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа 
(от 1 до 65536) или сообщает, что третьей цифры нет.
*/

Console.Clear();
int RndNumber = new Random().Next(1, 65536); //Генерируем случайное число

Console.WriteLine (RndNumber); // Показываем число на экране

if (RndNumber < 100) {
    Console.WriteLine("Третьей цифры в числе нет");
}
if (RndNumber >= 100 & RndNumber < 1000) {
    RndNumber = RndNumber % 10; //узнаем третью цифру числа остатком от деления
    Console.WriteLine("Третья цифра числа: " + RndNumber);
}
if (RndNumber >= 1000 & RndNumber < 10000) {
    RndNumber = RndNumber / 10;
    RndNumber = RndNumber % 10; //узнаем третью цифру числа остатком от деления
    Console.WriteLine("Третья цифра числа: " + RndNumber);
}
if (RndNumber >= 10000 & RndNumber <= 65536) {
    RndNumber = RndNumber / 100;
    RndNumber = RndNumber % 10; //узнаем третью цифру числа остатком от деления
    Console.WriteLine("Третья цифра числа: " + RndNumber);
}
