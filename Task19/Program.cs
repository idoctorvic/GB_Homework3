// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

Console.Write("Enter a 5-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 10 == num / 10000) && (num / 10 % 10 == num /1000 % 10 ))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

