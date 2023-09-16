Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "john")
{
   Console.WriteLine("Ура, это же JOHN!");
}
else
{
   Console.Write("Привет, ");
   Console.WriteLine(username);
}