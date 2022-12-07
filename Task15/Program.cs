/* Задача 15: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("Ведите номер дня недели от 1 до 7");
string dayNumber = Console.ReadLine();
if (dayNumber == "1")
Console.WriteLine("Monday");
else if (dayNumber == "2")
Console.WriteLine("Tuesday");
else if (dayNumber == "3")
Console.WriteLine("Wednesday");
else if (dayNumber == "4")
Console.WriteLine("Thursaday");
else if (dayNumber == "5")
Console.WriteLine("Friday");
else if (dayNumber == "6")
Console.WriteLine("Saturday - Weekend");
else if (dayNumber == "7")
Console.WriteLine("Sunday - Weekend");
else
{
    Console.WriteLine("Вы ввели неверное число. Попробуйте еще раз.");
}
