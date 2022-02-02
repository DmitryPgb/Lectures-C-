Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "katja")
{
    Console.WriteLine("Hooray, this is KATJA!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}