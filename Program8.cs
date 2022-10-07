Console.WriteLine("Вывод четных чисел от 1 до N");
Console.WriteLine("Введите N: ");

string input = Console.ReadLine();
int N = int.Parse(input);

int i = 1;

while (i <= N)
{
    if ((i % 2) == 0)
    {
        Console.Write($"{i} ");
    };
    i = (i + 1);
};