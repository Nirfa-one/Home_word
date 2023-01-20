Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int num = Convert.ToInt32(numberStr);


for (int i = - num; i <= num; i++) {
    if (i % 2 == 0 & i > 0) {
       Console.WriteLine(i); 
    }
}
