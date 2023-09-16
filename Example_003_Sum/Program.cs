//программа для суммирования двух чисел, получаемых от пользователя
Console.WriteLine("Программа для суммирования двух чисел, получаемых от пользователя!");
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA + numberB;
Console.WriteLine("Сумма Ваших чисел равна: " + result);