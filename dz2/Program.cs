Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int num = Convert.ToInt32(numberStr);


if (num % 2 == 0) {
    Console.WriteLine("Число четное!");
 } else {
   Console.WriteLine("Число не четное!"); 
 }
