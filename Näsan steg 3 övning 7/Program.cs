using System;
class Program
{

static void Main(string[] args)
{

int userPick = GetChoice("Björk", "Ek", "Tall");
if(userPick == 1)
{
    Console.WriteLine($"Du valde nummer {userPick}, Björk");
}else if(userPick == 2)
{
    Console.WriteLine($"Du valde nummer {userPick}, Ek");
}else
{
    Console.WriteLine($"Du valde nummer {userPick}, Tall");
}
Console.ReadLine();

}

static int GetChoice(string pick1, string pick2, string pick3)
    {
    int pick = 0;
    bool Clearing = false;

    while(!Clearing)
        {
        Console.WriteLine("Välj en av följande alternativ genom att skriva dess siffra");
        Console.WriteLine("1:" + pick1);
        Console.WriteLine("2:" + pick2);
        Console.WriteLine("3:" + pick3);
    

    string Input = Console.ReadLine();

    if(int.TryParse(Input, out pick) && pick <= 3 && pick >=1)
    {
        Clearing = true;
    }else{
        Console.Clear();
        Thread.Sleep(100);
        Console.WriteLine("Fel, försök igen");
            }
        }
    return pick;
    }
}