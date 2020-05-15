using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  class Program
  {
    public static void Main()
    {
      Start();
    }

    public static void Start()
    {
      bool play = true;
      while(play == true)
      {
        Console.WriteLine("Welcome to Word Counter!");
        Console.WriteLine("We will be counting the number of times your chosen word appears in your chosen sentence.");
        Enter:

        GetWordCount();
      
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
    public static void GetWordCount()
    {
      Console.WriteLine("Enter your word.");
      string wordInput = Console.ReadLine();
      Console.WriteLine("Enter your sentence.");
      string sentenceInput = Console.ReadLine();

      while (sentenceInput == "")
      {
        Console.WriteLine("Sorry please input a sentence to compare.");
        sentenceInput = Console.ReadLine();
      }

      RepeatCounter userInput = new RepeatCounter (wordInput, sentenceInput);
      int count = userInput.WordCount();
      Console.WriteLine("Your word was " + wordInput + " and was used " + count + " times in the provided sentence.");
    }
  }
}