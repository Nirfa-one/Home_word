Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

int result = 0;

if (a > b) { result = a; }
if (b > a) { result = b; }

Console.WriteLine($"Большим числом является{result}");