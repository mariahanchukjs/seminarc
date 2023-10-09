// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
Console.WriteLine("Введите треx3начное число: ");
string numb = Console.ReadLine();
int number;
number = int.Parse(numb);
if(number<<1000 & number>99)
    {
        int lastDigit = number%10;
        Console.WriteLine ("lastDigit="+lastDigit);
    }
else
        Console.WriteLine("LastDigit not three digits");