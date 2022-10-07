// See https://aka.ms/new-console-template for more information
Console.WriteLine("Определяем четность числа. Введите число: ");

string input = Console.ReadLine();
int N = int.Parse(input);

int ost = (N % 2);
if (ost == 0) {System.Console.WriteLine("Число четное");} else {System.Console.WriteLine("Число нечетное");};