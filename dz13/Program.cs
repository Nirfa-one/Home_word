Console.Write("Введи число ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
if (stringNumber.Length > 2){
  Console.WriteLine("Третья цифра " + stringNumber[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}