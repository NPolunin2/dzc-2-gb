// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Math.Log10(a));
int i = 0;
Console.WriteLine($"{a}  {i} {l}");
int rev = 0, b;
//condition to check if the number is not 0
while (a != 0)
{
    b = a % 10;        //extract a digit
    rev = (rev * 10) + b;   //reverse the digits logic
    a = a / 10;             //remained number
    Console.WriteLine("The reverse of the number is: " + rev + "  " + a + "  " + b);

}
Console.WriteLine("The reverse of the number is: " + rev);

int tail = rev / 10;

Console.WriteLine("The reverse of the number is: " + rev + "  " + tail + "  " + a);
int x = a;
int y = x;
int i = 0;
int c = 0;

while (y >= 10)
{
    i++;
    y = y / 10;
}
while (c < i)
{
    c++;
    int z = x % 10;
    x = x / 10;
    Console.WriteLine($"{y} {x} {i} {z}");
}
Console.WriteLine($"s{i}");