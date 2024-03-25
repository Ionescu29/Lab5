// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Scrieti un program care sa verifice daca un sir de caractere citit de la
//tastatura este sau nu palindrom
Console.WriteLine("introduceti sirul");
string s = char.Parse(Console.ReadLine());
for (int i = 0; i < s.Lenght; i++)
{
    if (s[i] != s[s.lenght - i - 1])
    {
        Console.WriteLine("Sirul este palindrom");
    }
    else
    {
        Console.WriteLine("sirul nu este plaindrom");
    }
}
