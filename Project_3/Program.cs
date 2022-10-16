// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Get(string message)
{
    Console.WriteLine(message);
    string numberAStr = Console.ReadLine();
    int numberA = Convert.ToInt32(numberAStr);
    return numberA;
}
string Days(int number)
{
    if(number == 1) return "Понедельник"; 
    if(number == 2) return "Вторник"; 
    if(number == 3) return "Среда"; 
    if(number == 4) return "Четверг"; 
    if(number == 5) return "Пятница"; 
    if(number == 6) return "Суббота"; 
    if(number == 7) return "Восскресение"; 
    return "-1";
}
void Print(string message)
{
    Console.WriteLine(message);
}

int number = Get("Введите число от 1 до 7:");
if (number >= 1 && number <= 5)
{ 
    string day = Days(number);
    Print($"Ваше число {number} это {day},что не является выходным");
}
else if(number >= 6 && number <= 7)
{ 
    string day = Days(number);
    Print($"Ваше число {number} это {day},что является выходным");
}
else Print("Вы ввели некорректное число!");