//  Напишите программу, которая принимает на вход трехзначное
// число и на выходе показывает вторую цифру этого числа

int  N = new Random().Next(100,1000);
Console.WriteLine("Компьютер выбрал число:" + N);
int a1 = N/10;
int a2 = a1%10;

Console.WriteLine("Вторая цифра" + a2);
