// Написать программу, которая на вход принимает два числа и выводит, какое число большее, а какое меньшее.

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1>number2) {
    Console.WriteLine($"`{number1}` большее число `{number2}` меньшее число");
}    
else if (number2>number1)
{
    Console.WriteLine($"`{number2}` большее число `{number1}` меньшее число");
}    
else 
{
    Console.WriteLine($"`{number1}` равно `{number2}`");
}    