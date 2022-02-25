using System;
using System.Collections.Generic;
using System.Linq;

Main();

void Main()
{
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("Ask your question quickly, Magic Moose is busy.");
    Console.WriteLine("-----------------------------------------------");

    MoosePredicts();
}

void MoosePredicts()
{
    List<string> possiblePredictions = new List<string>() 
    { 
        "As I see it, yes.",
        "Ask again later.",
        "Better not tell you now.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Don't count on it.",
        "It is certain.",
        "It is decidedly so.",
        "Most likely.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Outlook good.",
        "Reply hazy, try again.",
        "Signs point to yes.",
        "Very doubtful.",
        "Without a doubt.",
        "Yes.",
        "Yes - definitely.",
        "You may rely on it." 
    };

    Console.Write($"Ask your question:");
    string answer = Console.ReadLine().ToLower();
    
    if(string.IsNullOrEmpty(answer))
    {
        Environment.Exit(0);
    }
    else
    {
        Random r = new Random();
        int rando= r.Next(0,18);
        string spiritMessage = possiblePredictions[rando];
        Console.Write($"The spirits tell me... '{spiritMessage}'");        
        Environment.Exit(0);
    }
}


