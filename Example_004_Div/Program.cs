//программа для деления двух чисел, получаемых от пользователя
Console.WriteLine("Программа для деления двух чисел, получаемых от пользователя!");
Console.Write("Введите первое число: ");
double numberA = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = double.Parse(Console.ReadLine());
double result = numberA / numberB;
Console.WriteLine("Результат деления Ваших чисел равен: " + result);