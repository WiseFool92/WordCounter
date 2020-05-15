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
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Welcome to Word Counter!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("We will be counting the number of times your chosen word appears in your chosen sentence.");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Enter:

        GetWordCount();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Shall we do another?\n\n[Y/N]");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

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
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Enter your word.");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      string wordInput = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Enter your sentence.");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      string sentenceInput = Console.ReadLine();

      while (sentenceInput == "")
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Sorry please input a sentence to compare.");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        sentenceInput = Console.ReadLine();
      }

      RepeatCounter userInput = new RepeatCounter (wordInput, sentenceInput);
      int count = userInput.WordCount();
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Your word was " + wordInput + " and was used " + count + " times in the provided sentence.");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
  }
}