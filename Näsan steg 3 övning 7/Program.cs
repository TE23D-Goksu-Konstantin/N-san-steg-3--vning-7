using System;
class Program
{
static void Main(string[] args)
    {
        string word;
        bool choice = false;
        int counter = 3;
        List<string> excel = new List<string>();

for(int e=0; e<3; ++e)
        {
            Console.Clear();
            Console.WriteLine("Skriv in ett ord.");
            word = Console.ReadLine();
                excel.Add(word);  

        }
        Console.Clear();
        
        for(int i=0; i<excel.Count; ++i)
        {
            Console.WriteLine($"Word {i + 1}: {excel[i]}");
            Console.ReadLine();
        }

    }




static int GetChoice(int userchoice)
{
    return userchoice;
}



    
}