// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Get(string message)
{
    Console.WriteLine(message);
    string numberAStr = Console.ReadLine();
    int numberA = Convert.ToInt32(numberAStr);
    return numberA;
}
int CheckThirdDigit(int number)
{
    int count = 10;
    while(number / count > 10)
    {
        count = count*10;
    }
    return count/10;
}

int number = Get("Введите число:");

if(number>99)
{
    int count = CheckThirdDigit(number);
    int thirdDigit = (number%count)/(count/10);
    Console.WriteLine ($"Третья цифра числа {number} равна {thirdDigit}.");
}
else Console.WriteLine ("Третьей цифры нет");