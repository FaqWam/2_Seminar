Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a / 100 > 0) 
Console.WriteLine("Третья цифра " + a % 10);
else 
Console.WriteLine("У числа нет третьей цифры");
