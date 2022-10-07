System.Console.WriteLine("Введите первое число:");
string input = Console.ReadLine();
int one = int.Parse(input);

System.Console.WriteLine("Введите второе число:");
input = Console.ReadLine();
int two = int.Parse(input);

if (one > two) {System.Console.WriteLine("Первое число больше");} else if (two > one) {System.Console.WriteLine("Второе число больше");} else System.Console.WriteLine("Числа равны");