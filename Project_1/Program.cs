// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Get(string message)
{
    Console.WriteLine(message);
    string numberAStr = Console.ReadLine();
    int numberA = Convert.ToInt32(numberAStr);
    return numberA;
}

int number = Get("Введите трехзначное число:");
if (number > 99 && number < 1000)
{
    int secondDigit = (number % 100)/10;
    Console.WriteLine ($"Вторая цифра числа {number} равна {secondDigit}.");
}
else  Console.WriteLine ("Вы ввели не трехзначное число");