//Перше завдання 
/*int[] number = new int[4];
number[0] = Convert.ToInt32(Console.ReadLine());
number[1] = Convert.ToInt32(Console.ReadLine());
number[2] = Convert.ToInt32(Console.ReadLine());
number[3] = Convert.ToInt32(Console.ReadLine());

int result = number[0] * 1000 + number[1] * 100 + number[2] * 10 + number[3];
Console.WriteLine(result);*/

//Друге завдання 
/*int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 100000;
int number2 = number / 10000 % 10;
int number3 = number / 1000 % 10;
int number4 = number / 100 % 10;
int number5 = number / 10 % 10;
int number6 = number % 10;
Console.WriteLine($"{number1}{number2}{number3}{number4}{number5}{number6}");
Console.WriteLine($"{number6}{number5}{number4}{number3}{number2}{number1}");*/

//Перше додаткове 
/*int[] number = new int[3];
number[0] = Convert.ToInt32(Console.ReadLine());
number[1] = Convert.ToInt32(Console.ReadLine());
number[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum: {number[0] + number[1] + number[2]}");
Console.WriteLine($"Arithmetic mean: {(number[0] + number[1] + number[2]) / 3}");*/

//Друге додаткове 

/*int price = Convert.ToInt32(Console.ReadLine());
int amount = Convert.ToInt32(Console.ReadLine());
int discountPercent = Convert.ToInt32(Console.ReadLine());
if (discountPercent > 100)
{
    Console.WriteLine($"Error\a");
}
int discountNumber = price / 100 * discountPercent;
int total = (price - discountNumber) * amount;
Console.WriteLine(total);*/

//Третє додаткове

/*int salary = 100;
int moneyFromSales = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(salary + (moneyFromSales / 100 * 5));*/

//Четверте завдання 
double size = Convert.ToDouble(Console.ReadLine());
double speed = Convert.ToDouble(Console.ReadLine());
double speed1 = size * 8 * Math.Pow(10, 9);
double timeInSeconds = size / speed;
int hours = (int)timeInSeconds / 3600;
int minutes = (int)timeInSeconds % 3600 / 60;
int seconds = (int)timeInSeconds % 60;
Console.WriteLine($"{hours} {minutes} {seconds}");