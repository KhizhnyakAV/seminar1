System.Console.Write("Введите первое число: ");
string input = Console.ReadLine();
int one = int.Parse(input);

System.Console.Write("Введите второе число: ");
input = Console.ReadLine();
int two = int.Parse(input);

System.Console.Write("Введите третье число: ");
input = Console.ReadLine();
int three = int.Parse(input);

if ((one > two) & (one > three)) { System.Console.WriteLine($"Наибольшее число - первое ({one})"); };
if ((two > one) & (two > three)) { System.Console.WriteLine($"Наибольшее число - второе ({two})"); };
if ((three > one) & (three > two)) { System.Console.WriteLine($"Наибольшее число - третье ({three})"); };