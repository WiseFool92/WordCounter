using System;
using System.Collections.Generic;
using WordCounter.Model;

namespace WordCounter
{
  class Program
  {
    public static void Main()
    {
      Start();
    }
    
    public void Start()
    {
      bool play = true;
      while(play == true)
      {
        Console.WriteLine("Welcome to Word Counter!");
        Console.WriteLine("We will be counting the number of of times your chosen word appears in your chosen sentence.");
        Enter:


        Console.WriteLine("Enter your word.");
        string wordInput = Console.ReadLine();
        Console.WriteLine("Enter your sentence.");
        string sentenceInput = Console.ReadLine();
        GetWordCount(input);
        DisplayWordCount();

        Console.WriteLine("Shall we do another?\n\n[Y/N]");
        string response = (Console.ReadLine().ToLower());
        if (response == "y")
        {
          goto Enter;
        }
        else
        {
          play = false;
        }
      }
    }
  }
}