Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "marry")
{
    Console.WriteLine("Ура, это же Marry");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}