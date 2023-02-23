// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Task_26();
Task_28();

static void Task_26()
{
int number = Prompt("Введите число.");
CountOfNumber(number);
}

static int Prompt(string message)
{
Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

static void CountOfNumber (int userNumber)
{
char [] number = userNumber.ToString().ToCharArray();
Console.WriteLine($"{number.Length }");
}

static void Task_28()
{
int number = Prompt("Введите число");
int result = MultiPly(number);
Console.WriteLine($"Произведение числе от 1 до {number} = {result}.");
}

static int MultiPly(int userNumber)
{
int result = 1;
for (int i = 1; i <= userNumber; i++)
{
result *= i;
}
return result;
}