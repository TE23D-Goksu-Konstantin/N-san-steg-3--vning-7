using System;
class Program
{

static void Main(string[] args)
{

int userPick = GetChoice("Björk", "Ek", "Tall");
Console.WriteLine($"Du valde {userPick}");

}

static int GetChoice(string pick1, string pick2, string pick3)
{
    int pick;
    bool Clearing = false;

    while(!Clearing)
    {
        Console.WriteLine("Välj en av följande alternativ genom att skriva dess siffra");
        Console.WriteLine("1:" + pick1);
        Console.WriteLine("2:" + pick2);
        Console.WriteLine("3:" + pick3);
    }

    string Input = Console.ReadLine();

    if(int.TryParse(Input, out pick) && pick <= 3 && pick &&)
    {
        Clearing = true;
    }else{
        Console.WriteLine("Fel, skriv in en siffra");
    }
    return pick;
}

}