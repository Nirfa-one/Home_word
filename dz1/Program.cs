Console.WriteLine("Введите первое число!");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число!");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

Console.WriteLine("Введите третье число!");
string numberStr3 = Console.ReadLine();
int c = Convert.ToInt32(numberStr3);

int result = 0;

if (a > b & a > c) { result = a; }
if (b > a & b > c) { result = b; }
if (c > a & c > b) { result = c; }

Console.WriteLine($"Большим числом является {result}");
