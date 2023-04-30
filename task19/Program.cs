// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
string number = Console.ReadLine();

bool GetPalindrom(string number)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром");
        return true;
    }
    return false;
}
bool ValidateNumber(string number)
{
    if (number.Length == 5)
    {
       return true;
    }
     Console.WriteLine("Не является пятизначным числом");
    return false;
}

if (ValidateNumber(number))
{
    Console.WriteLine(GetPalindrom(number));
}