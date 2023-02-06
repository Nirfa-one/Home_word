Console.Write("Введи цифру, обозначающую день недели ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int number) {
  if (number == 6 || number == 7) {
  Console.WriteLine("Этот день выходной!");
  }
  else if (number < 1 || number > 7) {
    Console.WriteLine("Такого дня не существует!");
  }
  else Console.WriteLine("Это будний день!");
}

CheckingTheDayOfTheWeek(number);
