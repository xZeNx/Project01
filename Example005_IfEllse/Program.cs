Console.Write("Представтесь:");
string username = Console.ReadLine();

if(username.ToLower() == "сергей")
{
    Console.WriteLine("Приветствую Серёга!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}